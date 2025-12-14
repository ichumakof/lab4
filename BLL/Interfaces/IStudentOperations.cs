using BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IStudentOperations
    {
        // Специфичные операции для студентов
        List<StudentDTO> GetStudentsByCourse(int course);
        double GetStudentAverageMark(int studentId);
        bool CanReceiveScholarship(int studentId);
        List<StudentDTO> GetStudentsForComboBox();
    }
}