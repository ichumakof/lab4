using DAL.Interfaces;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLab8.Mocks
{
    public class MockReportRepository
    {
        public Mock<IReportRepository> Mock { get; }
        public List<TopStudentInfo> TopStudents { get; set; }
        public List<ScholarshipInfo> ScholarshipStudents { get; set; }
        public List<ScholarshipTypeInfo> ScholarshipTypes { get; set; }

        public MockReportRepository()
        {
            Mock = new Mock<IReportRepository>();

            // Инициализация тестовыми данными
            TopStudents = TestData.GetTopStudents();
            ScholarshipStudents = TestData.GetScholarshipStudents();
            ScholarshipTypes = TestData.GetScholarshipTypes();

            ConfigureMock();
        }

        private void ConfigureMock()
        {
            // GetTopStudents()
            Mock.Setup(r => r.GetTopStudents())
                .Returns(TopStudents);

            // GetStudentsByScholarship(scholarshipTypeId)
            Mock.Setup(r => r.GetStudentsByScholarship(It.IsAny<long>()))
                .Returns((long scholarshipTypeId) =>
                {
                    var typeName = ScholarshipTypes
                        .FirstOrDefault(t => t.Id_type_of_scholarship == scholarshipTypeId)?.Name;

                    return ScholarshipStudents
                        .Where(s => s.TypeOfScholarship == typeName)
                        .ToList();
                });

            // GetScholarshipTypesForComboBox()
            Mock.Setup(r => r.GetScholarshipTypesForComboBox())
                .Returns(ScholarshipTypes);
        }
    }
}
