using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;

namespace DAL.Repository
{
    public class ReportRepository : IReportRepository
    {
        private readonly Students2Entities _context;

        public ReportRepository(Students2Entities context)
        {
            _context = context;
        }

        // LINQ запрос
        public List<TopStudentInfo> GetTopStudents()
        {
            var query = from student in _context.Students
                        join mark in _context.Marks on student.Id equals mark.Id_of_Student_FK_
                        where mark.value != null
                        group mark by new { student.Id, student.full_name } into g
                        let averageGrade = g.Average(gr => (int)gr.value.Value)
                        where averageGrade >= 4
                        select new TopStudentInfo
                        {
                            FullName = g.Key.full_name,
                            AverageMark = System.Math.Round(averageGrade, 2)
                        };

            return query.ToList();
        }

        // Хранимая процедура
        public List<ScholarshipInfo> GetStudentsByScholarship(long scholarshipTypeId)
        {
            var results = _context.sp_scholars((int)scholarshipTypeId).ToList();

            return results.Select(r => new ScholarshipInfo
            {
                FullName = r.full_name,
                NumOfGradeBook = r.num_of_grade_book,
                Course = r.course,
                TypeOfScholarship = r.Type_of_scholarship
            }).ToList();
        }

        public List<ScholarshipTypeInfo> GetScholarshipTypesForComboBox()
        {
            return _context.Types_of_scholarships
                .Select(t => new ScholarshipTypeInfo
                {
                    Id_type_of_scholarship = t.Id_type_of_scholarship,
                    Name = t.name
                })
                .ToList();
        }
    }
}