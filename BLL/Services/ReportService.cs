using BLL.Interfaces;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ReportService : IReportService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ReportService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<TopStudentDTO> GetTopStudents()
        {
            var results = _unitOfWork.Reports.GetTopStudents();
            return results.ConvertAll(r => new TopStudentDTO
            {
                FullName = r.FullName,
                AverageMark = r.AverageMark
            });
        }

        public List<ScholarshipInfoDTO> GetStudentsByScholarship(long scholarshipTypeId)
        {
            var results = _unitOfWork.Reports.GetStudentsByScholarship(scholarshipTypeId);
            return results.ConvertAll(r => new ScholarshipInfoDTO
            {
                FullName = r.FullName,
                NumOfGradeBook = r.NumOfGradeBook,
                Course = r.Course,
                TypeOfScholarship = r.TypeOfScholarship
            });
        }

        public List<ScholarshipTypeDTO> GetScholarshipTypesForComboBox()
        {
            var results = _unitOfWork.Reports.GetScholarshipTypesForComboBox();
            return results.ConvertAll(r => new ScholarshipTypeDTO
            {
                Id_type_of_scholarship = r.Id_type_of_scholarship,
                Name = r.Name
            });
        }
    }
}