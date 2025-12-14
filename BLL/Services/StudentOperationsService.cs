using BLL.DTOs;
using BLL.Interfaces;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class StudentOperationsService : IStudentOperations
    {
        private readonly IUnitOfWork _unitOfWork;

        public StudentOperationsService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<StudentDTO> GetStudentsByCourse(int course)
        {
            var students = _unitOfWork.Students.GetAll()
                .Where(s => s.course == course)
                .ToList();

            return students.Select(s => new StudentDTO
            {
                Id = s.Id,
                FullName = s.full_name,
                NumOfGradeBook = s.num_of_grade_book,
                Course = s.course
            }).ToList();
        }

        public double GetStudentAverageMark(int studentId)
        {
            var marks = _unitOfWork.Marks.GetAll()
                .Where(m => m.Id_of_Student_FK_ == studentId && m.value != null)
                .ToList();

            if (marks.Count == 0) return 0;

            return marks.Average(m => (double)m.value.Value);
        }

        public bool CanReceiveScholarship(int studentId)
        {
            var averageMark = GetStudentAverageMark(studentId);
            return averageMark >= 4.0; // Стипендия если средний балл >= 4.0
        }

        public List<StudentDTO> GetStudentsForComboBox()
        {
            var students = _unitOfWork.Students.GetAll();
            return students.Select(s => new StudentDTO
            {
                Id = s.Id,
                FullName = s.full_name
            }).ToList();
        }
    }
}