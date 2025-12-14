using BLL.DTOs;
using BLL.Interfaces;
using DAL;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class DbCrudService : IDbCrud
    {
        private readonly IUnitOfWork _unitOfWork;

        public DbCrudService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        /// <summary> СТУДЕНТЫ </summary>
        public List<StudentDTO> GetAllStudents()
        {
            var students = _unitOfWork.Students.GetAll();
            return students.Select(s => new StudentDTO
            {
                Id = s.Id,
                FullName = s.full_name,
                NumOfGradeBook = s.num_of_grade_book,
                Course = s.course
            }).ToList();
        }

        public StudentDTO GetStudent(int id)
        {
            var student = _unitOfWork.Students.GetById(id);
            if (student == null) return null;

            return new StudentDTO
            {
                Id = student.Id,
                FullName = student.full_name,
                NumOfGradeBook = student.num_of_grade_book,
                Course = student.course
            };
        }

        public void CreateStudent(StudentDTO studentDto)
        {
            var student = new Students
            {
                full_name = studentDto.FullName,
                num_of_grade_book = studentDto.NumOfGradeBook,
                course = studentDto.Course
            };

            _unitOfWork.Students.Add(student);
            Save();
        }

        public void UpdateStudent(StudentDTO studentDto)
        {
            var student = _unitOfWork.Students.GetById(studentDto.Id);
            if (student == null) return;

            student.full_name = studentDto.FullName;
            student.num_of_grade_book = studentDto.NumOfGradeBook;
            student.course = studentDto.Course;

            Save();
        }

        public void DeleteStudent(int id)
        {
            var student = _unitOfWork.Students.GetById(id);
            if (student != null)
            {
                _unitOfWork.Students.Delete(student);
                Save();
            }
        }

        /// <summary> ОЦЕНКИ </summary>
        public List<MarkDTO> GetAllMarks()
        {
            var marks = _unitOfWork.Marks.GetAll();
            var result = new List<MarkDTO>();

            foreach (var mark in marks)
            {
                var student = _unitOfWork.Students.GetById((int)mark.Id_of_Student_FK_);

                result.Add(new MarkDTO
                {
                    Id = mark.Id,
                    Semester = mark.semester,
                    Value = mark.value,
                    StudentName = student?.full_name ?? "Неизвестный студент",
                    StudentId = mark.Id_of_Student_FK_
                });
            }

            return result;
        }

        public MarkDTO GetMark(int id)
        {
            var mark = _unitOfWork.Marks.GetById(id);
            if (mark == null) return null;

            return new MarkDTO
            {
                Id = mark.Id,
                Value = mark.value,
                Semester = mark.semester,
                StudentId = mark.Id_of_Student_FK_
            };
        }

        public void CreateMark(MarkDTO markDto)
        {
            if (!ValidateMark(markDto))
                throw new ArgumentException("Некорректные данные оценки");

            var mark = new Marks
            {
                value = markDto.Value,
                semester = markDto.Semester,
                Id_of_Student_FK_ = markDto.StudentId
            };

            _unitOfWork.Marks.Add(mark);
            Save();
        }

        public void UpdateMark(MarkDTO markDto)
        {
            var mark = _unitOfWork.Marks.GetById(markDto.Id);
            if (mark == null) return;

            if (!ValidateMark(markDto))
                throw new ArgumentException("Некорректные данные оценки");

            mark.value = markDto.Value;
            mark.semester = markDto.Semester;
            mark.Id_of_Student_FK_ = markDto.StudentId;

            Save();
        }

        public void DeleteMark(int id)
        {
            var mark = _unitOfWork.Marks.GetById(id);
            if (mark != null)
            {
                _unitOfWork.Marks.Delete(mark);
                Save();
            }
        }

        public void Save()
        {
            _unitOfWork.Save();
        }

        private bool ValidateMark(MarkDTO mark)
        {
            if (mark.Value < 2 || mark.Value > 5)
                return false;

            if (mark.Semester < 1 || mark.Semester > 12)
                return false;

            return true;
        }
    }
}