using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IReportService
    {
        // LINQ запрос
        List<TopStudentDTO> GetTopStudents();

        // Хранимая процедура
        List<ScholarshipInfoDTO> GetStudentsByScholarship(long scholarshipTypeId);
        List<ScholarshipTypeDTO> GetScholarshipTypesForComboBox();
    }

    // DTO для отчетов
    public class TopStudentDTO
    {
        public string FullName { get; set; }
        public double AverageMark { get; set; }
    }

    public class ScholarshipInfoDTO
    {
        public string FullName { get; set; }
        public int? NumOfGradeBook { get; set; }
        public int? Course { get; set; }
        public string TypeOfScholarship { get; set; }
    }

    public class ScholarshipTypeDTO
    {
        public long Id_type_of_scholarship { get; set; }
        public string Name { get; set; }
    }
}