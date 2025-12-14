using BLL.DTOs;
using BLL.Interfaces;
using System;
using System.Windows.Forms;

namespace Lab3NLayerArch
{
    public partial class MainForm : Form
    {
        // конкретные сервисы на интерфейсы
        private readonly IDbCrud _dbCrud;
        private readonly IReportService _reportService;
        private readonly IStudentOperations _studentOperations;

        // Конструктор получает зависимости извне
        public MainForm(IDbCrud dbCrud, IReportService reportService, IStudentOperations studentOperations)
        {
            _dbCrud = dbCrud;
            _reportService = reportService;
            _studentOperations = studentOperations;

            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadStudents();
            LoadMarks();
            LoadScholarshipTypes();
        }

        /// <summary> загрузка студентов </summary>
        private void LoadStudents()
        {
            var students = _dbCrud.GetAllStudents(); // IDbCrud
            dataGridViewStudents.DataSource = students;
        }

        /// <summary> загрузка оценок </summary>
        private void LoadMarks()
        {
            var marks = _dbCrud.GetAllMarks(); // IDbCrud
            dataGridViewMarks.DataSource = marks;
        }

        /// <summary> загрузка типов стипендий </summary>
        private void LoadScholarshipTypes()
        {
            var scholarshipTypes = _reportService.GetScholarshipTypesForComboBox(); // IReportService
            comboBoxScholarshipTypes.DataSource = scholarshipTypes;
            comboBoxScholarshipTypes.DisplayMember = "Name";
            comboBoxScholarshipTypes.ValueMember = "Id_type_of_scholarship";
        }

        /// <summary> добавление нового студента </summary>
        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            EditStudentForm f = new EditStudentForm();

            DialogResult result = f.ShowDialog(this);
            if (result == DialogResult.Cancel)
                return;

            try
            {
                var studentDto = new StudentDTO
                {
                    FullName = f.textBoxFIO.Text,
                    NumOfGradeBook = int.Parse(f.textBoxGradebook.Text),
                    Course = (byte)f.numericUpDownCourse.Value
                };

                _dbCrud.CreateStudent(studentDto);
                LoadStudents();
                MessageBox.Show("Новый студент добавлен!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка");
            }
        }

        /// <summary> редактирование студента </summary>
        private void buttonEditStudent_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudents.CurrentRow?.DataBoundItem is StudentDTO student)
            {
                EditStudentForm f = new EditStudentForm();

                // Заполняем форму текущими значениями
                f.textBoxFIO.Text = student.FullName;
                f.textBoxGradebook.Text = student.NumOfGradeBook?.ToString();
                f.numericUpDownCourse.Value = student.Course ?? 1;

                DialogResult result = f.ShowDialog(this);
                if (result == DialogResult.Cancel)
                    return;

                // Обновляем через сервис
                student.FullName = f.textBoxFIO.Text;
                student.NumOfGradeBook = int.Parse(f.textBoxGradebook.Text);
                student.Course = (byte)f.numericUpDownCourse.Value;

                _dbCrud.UpdateStudent(student);
                LoadStudents();
                MessageBox.Show("Данные студента обновлены!");
            }
            else
            {
                MessageBox.Show("Выберите студента для редактирования!", "Ошибка");
            }
        }

        /// <summary> удаление студента </summary>
        private void buttonDeleteStudent_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudents.CurrentRow?.DataBoundItem is StudentDTO student)
            {
                if (MessageBox.Show($"Удалить студента {student.FullName}?", "Подтверждение",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _dbCrud.DeleteStudent(student.Id);
                    LoadStudents();
                    MessageBox.Show("Студент удален!");
                }
            }
            else
            {
                MessageBox.Show("Выберите студента для удаления!", "Ошибка");
            }
        }

        /// <summary> добавление новой оценки </summary>
        private void buttonAddMark_Click(object sender, EventArgs e)
        {
            EditGradeForm f = new EditGradeForm();

            f.comboBoxStudent.DataSource = _studentOperations.GetStudentsForComboBox();
            f.comboBoxStudent.DisplayMember = "FullName";
            f.comboBoxStudent.ValueMember = "Id";

            DialogResult result = f.ShowDialog(this);
            if (result == DialogResult.Cancel)
                return;

            try
            {
                var markDto = new MarkDTO
                {
                    Value = (int)f.numericUpDownValue.Value,
                    Semester = (int)f.numericUpDownSemester.Value,
                    StudentId = (int)f.comboBoxStudent.SelectedValue
                };

                _dbCrud.CreateMark(markDto);
                LoadMarks();
                MessageBox.Show("Новая оценка добавлена!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка");
            }
        }

        /// <summary> редактирование оценки </summary>
        private void buttonEditMark_Click(object sender, EventArgs e)
        {
            if (dataGridViewMarks.CurrentRow?.DataBoundItem is MarkDTO mark)
            {
                EditGradeForm f = new EditGradeForm();

                // заполняем ComboBox
                f.comboBoxStudent.DataSource = _studentOperations.GetStudentsForComboBox();
                f.comboBoxStudent.DisplayMember = "FullName";
                f.comboBoxStudent.ValueMember = "Id";

                // устанавливаем значения формы
                f.numericUpDownValue.Value = mark.Value ?? 0;
                f.numericUpDownSemester.Value = mark.Semester ?? 1;

                // Только после установки DataSource можно ставить SelectedValue
                if (mark.StudentId.HasValue)
                {
                    f.comboBoxStudent.SelectedValue = mark.StudentId.Value;
                }

                DialogResult result = f.ShowDialog(this);
                if (result == DialogResult.Cancel)
                    return;

                mark.Value = (int)f.numericUpDownValue.Value;
                mark.Semester = (int)f.numericUpDownSemester.Value;
                mark.StudentId = (int)f.comboBoxStudent.SelectedValue;

                _dbCrud.UpdateMark(mark);
                LoadMarks();
                MessageBox.Show("Данные оценки обновлены!");
            }
            else
            {
                MessageBox.Show("Выберите оценку для редактирования!", "Ошибка");
            }
        }

        /// <summary> удаление оценки </summary>
        private void buttonDeleteMark_Click(object sender, EventArgs e)
        {
            if (dataGridViewMarks.CurrentRow?.DataBoundItem is MarkDTO mark)
            {
                if (MessageBox.Show($"Удалить оценку?", "Подтверждение",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _dbCrud.DeleteMark(mark.Id);
                    LoadMarks();
                    MessageBox.Show("Оценка удалена!");
                }
            }
            else
            {
                MessageBox.Show("Выберите оценку для удаления!", "Ошибка");
            }
        }

        /// <summary> кнопка сохранить </summary>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Все изменения сохранены автоматически!", "Информация");
        }

        /// <summary> вызов хранимой процедуры </summary>
        private void buttonRunProcedure_Click(object sender, EventArgs e)
        {
            if (comboBoxScholarshipTypes.SelectedValue == null)
            {
                MessageBox.Show("Выберите тип стипендии!", "Ошибка");
                return;
            }

            long scholarshipTypeId = (long)comboBoxScholarshipTypes.SelectedValue;
            var results = _reportService.GetStudentsByScholarship(scholarshipTypeId);

            if (results.Count > 0)
            {
                dataGridViewProcedure.DataSource = results;
                MessageBox.Show($"Найдено {results.Count} студентов", "Результат");
            }
            else
            {
                dataGridViewProcedure.DataSource = null;
                MessageBox.Show("Студенты с выбранным типом стипендии не найдены", "Информация");
            }
        }

        /// <summary> LINQ запрос </summary>
        private void buttonExecuteLinq_Click(object sender, EventArgs e)
        {
            var results = _reportService.GetTopStudents();
            dataGridViewLinqResults.DataSource = results;
            MessageBox.Show($"Найдено {results.Count} студентов с средним баллом >= 4");
        }
    }
}