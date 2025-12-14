namespace Lab3NLayerArch
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonDeleteMark = new System.Windows.Forms.Button();
            this.buttonEditMark = new System.Windows.Forms.Button();
            this.buttonAddMarks = new System.Windows.Forms.Button();
            this.buttonSaveMarks = new System.Windows.Forms.Button();
            this.dataGridViewMarks = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonDeleteStudent = new System.Windows.Forms.Button();
            this.buttonEditStudent = new System.Windows.Forms.Button();
            this.buttonAddStudent = new System.Windows.Forms.Button();
            this.buttonSaveStudents = new System.Windows.Forms.Button();
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonExecuteLinq = new System.Windows.Forms.Button();
            this.dataGridViewLinqResults = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridViewProcedure = new System.Windows.Forms.DataGridView();
            this.comboBoxScholarshipTypes = new System.Windows.Forms.ComboBox();
            this.buttonRunProcedure = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semesterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numOfGradeBookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMarks)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLinqResults)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcedure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Location = new System.Drawing.Point(6, 6);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(987, 687);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonDeleteMark);
            this.tabPage1.Controls.Add(this.buttonEditMark);
            this.tabPage1.Controls.Add(this.buttonAddMarks);
            this.tabPage1.Controls.Add(this.buttonSaveMarks);
            this.tabPage1.Controls.Add(this.dataGridViewMarks);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(979, 658);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Оценки";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteMark
            // 
            this.buttonDeleteMark.Location = new System.Drawing.Point(714, 594);
            this.buttonDeleteMark.Name = "buttonDeleteMark";
            this.buttonDeleteMark.Size = new System.Drawing.Size(126, 53);
            this.buttonDeleteMark.TabIndex = 8;
            this.buttonDeleteMark.Text = "удалить";
            this.buttonDeleteMark.UseVisualStyleBackColor = true;
            this.buttonDeleteMark.Click += new System.EventHandler(this.buttonDeleteMark_Click);
            // 
            // buttonEditMark
            // 
            this.buttonEditMark.Location = new System.Drawing.Point(582, 594);
            this.buttonEditMark.Name = "buttonEditMark";
            this.buttonEditMark.Size = new System.Drawing.Size(126, 53);
            this.buttonEditMark.TabIndex = 7;
            this.buttonEditMark.Text = "редактировать";
            this.buttonEditMark.UseVisualStyleBackColor = true;
            this.buttonEditMark.Click += new System.EventHandler(this.buttonEditMark_Click);
            // 
            // buttonAddMarks
            // 
            this.buttonAddMarks.Location = new System.Drawing.Point(450, 594);
            this.buttonAddMarks.Name = "buttonAddMarks";
            this.buttonAddMarks.Size = new System.Drawing.Size(126, 53);
            this.buttonAddMarks.TabIndex = 6;
            this.buttonAddMarks.Text = "добавить";
            this.buttonAddMarks.UseVisualStyleBackColor = true;
            this.buttonAddMarks.Click += new System.EventHandler(this.buttonAddMark_Click);
            // 
            // buttonSaveMarks
            // 
            this.buttonSaveMarks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveMarks.Location = new System.Drawing.Point(846, 594);
            this.buttonSaveMarks.Name = "buttonSaveMarks";
            this.buttonSaveMarks.Size = new System.Drawing.Size(126, 53);
            this.buttonSaveMarks.TabIndex = 2;
            this.buttonSaveMarks.Text = "сохранить";
            this.buttonSaveMarks.UseVisualStyleBackColor = true;
            this.buttonSaveMarks.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // dataGridViewMarks
            // 
            this.dataGridViewMarks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMarks.AutoGenerateColumns = false;
            this.dataGridViewMarks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMarks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.valueDataGridViewTextBoxColumn,
            this.semesterDataGridViewTextBoxColumn,
            this.studentNameDataGridViewTextBoxColumn});
            this.dataGridViewMarks.DataSource = this.gradesBindingSource;
            this.dataGridViewMarks.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewMarks.Name = "dataGridViewMarks";
            this.dataGridViewMarks.RowHeadersWidth = 51;
            this.dataGridViewMarks.RowTemplate.Height = 24;
            this.dataGridViewMarks.Size = new System.Drawing.Size(966, 579);
            this.dataGridViewMarks.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonDeleteStudent);
            this.tabPage2.Controls.Add(this.buttonEditStudent);
            this.tabPage2.Controls.Add(this.buttonAddStudent);
            this.tabPage2.Controls.Add(this.buttonSaveStudents);
            this.tabPage2.Controls.Add(this.dataGridViewStudents);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(979, 658);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Студенты";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteStudent
            // 
            this.buttonDeleteStudent.Location = new System.Drawing.Point(714, 597);
            this.buttonDeleteStudent.Name = "buttonDeleteStudent";
            this.buttonDeleteStudent.Size = new System.Drawing.Size(126, 53);
            this.buttonDeleteStudent.TabIndex = 7;
            this.buttonDeleteStudent.Text = "удалить";
            this.buttonDeleteStudent.UseVisualStyleBackColor = true;
            this.buttonDeleteStudent.Click += new System.EventHandler(this.buttonDeleteStudent_Click);
            // 
            // buttonEditStudent
            // 
            this.buttonEditStudent.Location = new System.Drawing.Point(582, 597);
            this.buttonEditStudent.Name = "buttonEditStudent";
            this.buttonEditStudent.Size = new System.Drawing.Size(126, 53);
            this.buttonEditStudent.TabIndex = 6;
            this.buttonEditStudent.Text = "редактировать";
            this.buttonEditStudent.UseVisualStyleBackColor = true;
            this.buttonEditStudent.Click += new System.EventHandler(this.buttonEditStudent_Click);
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.Location = new System.Drawing.Point(450, 597);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(126, 53);
            this.buttonAddStudent.TabIndex = 5;
            this.buttonAddStudent.Text = "добавить";
            this.buttonAddStudent.UseVisualStyleBackColor = true;
            this.buttonAddStudent.Click += new System.EventHandler(this.buttonAddStudent_Click);
            // 
            // buttonSaveStudents
            // 
            this.buttonSaveStudents.Location = new System.Drawing.Point(846, 597);
            this.buttonSaveStudents.Name = "buttonSaveStudents";
            this.buttonSaveStudents.Size = new System.Drawing.Size(126, 53);
            this.buttonSaveStudents.TabIndex = 4;
            this.buttonSaveStudents.Text = "сохранить";
            this.buttonSaveStudents.UseVisualStyleBackColor = true;
            this.buttonSaveStudents.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.AutoGenerateColumns = false;
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.numOfGradeBookDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn});
            this.dataGridViewStudents.DataSource = this.studentsBindingSource;
            this.dataGridViewStudents.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.RowHeadersWidth = 51;
            this.dataGridViewStudents.RowTemplate.Height = 24;
            this.dataGridViewStudents.Size = new System.Drawing.Size(966, 579);
            this.dataGridViewStudents.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.buttonExecuteLinq);
            this.tabPage3.Controls.Add(this.dataGridViewLinqResults);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(979, 658);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "LINQ Запросы";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonExecuteLinq
            // 
            this.buttonExecuteLinq.Location = new System.Drawing.Point(852, 596);
            this.buttonExecuteLinq.Name = "buttonExecuteLinq";
            this.buttonExecuteLinq.Size = new System.Drawing.Size(121, 46);
            this.buttonExecuteLinq.TabIndex = 1;
            this.buttonExecuteLinq.Text = "Выполнить";
            this.buttonExecuteLinq.UseVisualStyleBackColor = true;
            this.buttonExecuteLinq.Click += new System.EventHandler(this.buttonExecuteLinq_Click);
            // 
            // dataGridViewLinqResults
            // 
            this.dataGridViewLinqResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLinqResults.Location = new System.Drawing.Point(7, 7);
            this.dataGridViewLinqResults.Name = "dataGridViewLinqResults";
            this.dataGridViewLinqResults.RowHeadersWidth = 51;
            this.dataGridViewLinqResults.RowTemplate.Height = 24;
            this.dataGridViewLinqResults.Size = new System.Drawing.Size(966, 578);
            this.dataGridViewLinqResults.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridViewProcedure);
            this.tabPage4.Controls.Add(this.comboBoxScholarshipTypes);
            this.tabPage4.Controls.Add(this.buttonRunProcedure);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(979, 658);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Хранимая процедура";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridViewProcedure
            // 
            this.dataGridViewProcedure.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProcedure.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewProcedure.Name = "dataGridViewProcedure";
            this.dataGridViewProcedure.RowHeadersWidth = 51;
            this.dataGridViewProcedure.RowTemplate.Height = 24;
            this.dataGridViewProcedure.Size = new System.Drawing.Size(966, 579);
            this.dataGridViewProcedure.TabIndex = 5;
            // 
            // comboBoxScholarshipTypes
            // 
            this.comboBoxScholarshipTypes.FormattingEnabled = true;
            this.comboBoxScholarshipTypes.Location = new System.Drawing.Point(614, 618);
            this.comboBoxScholarshipTypes.Name = "comboBoxScholarshipTypes";
            this.comboBoxScholarshipTypes.Size = new System.Drawing.Size(188, 24);
            this.comboBoxScholarshipTypes.TabIndex = 2;
            // 
            // buttonRunProcedure
            // 
            this.buttonRunProcedure.Location = new System.Drawing.Point(827, 607);
            this.buttonRunProcedure.Name = "buttonRunProcedure";
            this.buttonRunProcedure.Size = new System.Drawing.Size(146, 45);
            this.buttonRunProcedure.TabIndex = 1;
            this.buttonRunProcedure.Text = "выполнить";
            this.buttonRunProcedure.UseVisualStyleBackColor = true;
            this.buttonRunProcedure.Click += new System.EventHandler(this.buttonRunProcedure_Click);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Visible = false;
            this.idDataGridViewTextBoxColumn1.Width = 125;
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "Value";
            this.valueDataGridViewTextBoxColumn.HeaderText = "Оценка";
            this.valueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            this.valueDataGridViewTextBoxColumn.Width = 125;
            // 
            // semesterDataGridViewTextBoxColumn
            // 
            this.semesterDataGridViewTextBoxColumn.DataPropertyName = "Semester";
            this.semesterDataGridViewTextBoxColumn.HeaderText = "Семестр";
            this.semesterDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.semesterDataGridViewTextBoxColumn.Name = "semesterDataGridViewTextBoxColumn";
            this.semesterDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "StudentName";
            this.studentNameDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.studentNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            this.studentNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // gradesBindingSource
            // 
            this.gradesBindingSource.DataSource = typeof(BLL.DTOs.MarkDTO);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.fullNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // numOfGradeBookDataGridViewTextBoxColumn
            // 
            this.numOfGradeBookDataGridViewTextBoxColumn.DataPropertyName = "NumOfGradeBook";
            this.numOfGradeBookDataGridViewTextBoxColumn.HeaderText = "Зачетная Книжка";
            this.numOfGradeBookDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numOfGradeBookDataGridViewTextBoxColumn.Name = "numOfGradeBookDataGridViewTextBoxColumn";
            this.numOfGradeBookDataGridViewTextBoxColumn.Width = 125;
            // 
            // courseDataGridViewTextBoxColumn
            // 
            this.courseDataGridViewTextBoxColumn.DataPropertyName = "Course";
            this.courseDataGridViewTextBoxColumn.HeaderText = "Курс";
            this.courseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
            this.courseDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.AllowNew = true;
            this.studentsBindingSource.DataSource = typeof(BLL.DTOs.StudentDTO);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(579, 611);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Лучшие студенты (средний балл >= 4)";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1012, 712);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMarks)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLinqResults)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcedure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button buttonSaveMarks;
        private System.Windows.Forms.DataGridView dataGridViewMarks;
        private System.Windows.Forms.Button buttonSaveStudents;
        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.DataGridView dataGridViewProcedure;
        private System.Windows.Forms.ComboBox comboBoxScholarshipTypes;
        private System.Windows.Forms.Button buttonRunProcedure;
        private System.Windows.Forms.Button buttonAddStudent;
        private System.Windows.Forms.Button buttonAddMarks;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private System.Windows.Forms.BindingSource gradesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBook;
        private System.Windows.Forms.Button buttonEditMark;
        private System.Windows.Forms.Button buttonDeleteMark;
        private System.Windows.Forms.Button buttonDeleteStudent;
        private System.Windows.Forms.Button buttonEditStudent;
        private System.Windows.Forms.Button buttonExecuteLinq;
        private System.Windows.Forms.DataGridView dataGridViewLinqResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnMarkId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTerm;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semesterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numOfGradeBookDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}

