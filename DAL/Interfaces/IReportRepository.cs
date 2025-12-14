using DAL.ReportModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IReportRepository
    {
        List<TopStudentInfo> GetTopStudents();
        List<ScholarshipInfo> GetStudentsByScholarship(long scholarshipTypeId);
        List<ScholarshipTypeInfo> GetScholarshipTypesForComboBox();
    }

    // Свои модели в DAL
    public class TopStudentInfo
    {
        public string FullName { get; set; }
        public double AverageMark { get; set; }
    }

    public class ScholarshipInfo
    {
        public string FullName { get; set; }
        public int? NumOfGradeBook { get; set; }
        public int? Course { get; set; }
        public string TypeOfScholarship { get; set; }
    }

    public class ScholarshipTypeInfo
    {
        public long Id_type_of_scholarship { get; set; }
        public string Name { get; set; }
    }
}