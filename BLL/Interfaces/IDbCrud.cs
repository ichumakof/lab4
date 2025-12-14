using BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IDbCrud
    {
        // Студенты
        List<StudentDTO> GetAllStudents();
        StudentDTO GetStudent(int id);
        void CreateStudent(StudentDTO student);
        void UpdateStudent(StudentDTO student);
        void DeleteStudent(int id);

        // Оценки
        List<MarkDTO> GetAllMarks();
        MarkDTO GetMark(int id);
        void CreateMark(MarkDTO mark);
        void UpdateMark(MarkDTO mark);
        void DeleteMark(int id);

        void Save();
    }
}