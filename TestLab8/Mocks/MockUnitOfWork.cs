using DAL;
using DAL.Interfaces;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLab8.Mocks
{
    public class MockUnitOfWork
    {
        public Mock<IUnitOfWork> Mock { get; }
        public MockRepository<Students> StudentsRepository { get; }
        public MockRepository<Marks> MarksRepository { get; }
        public MockReportRepository ReportRepository { get; }

        public MockUnitOfWork()
        {
            Mock = new Mock<IUnitOfWork>();

            // Создаём репозитории с тестовыми данными
            StudentsRepository = new MockRepository<Students>(TestData.GetStudents());
            MarksRepository = new MockRepository<Marks>(TestData.GetMarks());
            ReportRepository = new MockReportRepository();

            ConfigureMock();
        }

        private void ConfigureMock()
        {
            // Students
            Mock.Setup(u => u.Students)
                .Returns(StudentsRepository.Mock.Object);

            // Marks
            Mock.Setup(u => u.Marks)
                .Returns(MarksRepository.Mock.Object);

            // Reports
            Mock.Setup(u => u.Reports)
                .Returns(ReportRepository.Mock.Object);

            // Save()
            Mock.Setup(u => u.Save())
                .Verifiable();

            // Dispose()
            Mock.Setup(u => u.Dispose())
                .Verifiable();
        }

        public void ResetData()
        {
            StudentsRepository.Data = TestData.GetStudents();
            MarksRepository.Data = TestData.GetMarks();
            ReportRepository.TopStudents = TestData.GetTopStudents();
            ReportRepository.ScholarshipStudents = TestData.GetScholarshipStudents();
            ReportRepository.ScholarshipTypes = TestData.GetScholarshipTypes();
        }
    }
}
