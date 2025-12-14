using BLL.Interfaces;
using BLL.Services;
using DAL.Interfaces;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using TestLab8.Mocks;

namespace TestLab8.Services
{
    [TestFixture]
    public class ReportServiceTests
    {
        private Mock<IUnitOfWork> _unitOfWorkMock;
        private MockReportRepository _mockReportRepository;
        private ReportService _reportService;

        [SetUp]
        public void Setup()
        {
            // Создаём моковый репозиторий отчётов
            _mockReportRepository = new MockReportRepository();

            // Создаём мок UnitOfWork
            _unitOfWorkMock = new Mock<IUnitOfWork>();
            _unitOfWorkMock.Setup(u => u.Reports)
                .Returns(_mockReportRepository.Mock.Object);

            // Создаём тестируемый сервис
            _reportService = new ReportService(_unitOfWorkMock.Object);
        }

        // 1. Базовый тест: получение топ-студентов
        [Test]
        public void GetTopStudents_ShouldReturnCorrectData()
        {
            // Act
            var result = _reportService.GetTopStudents();

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count, Is.EqualTo(3));
            Assert.That(result[0].FullName, Is.EqualTo("Иванов И.И."));
            Assert.That(result[0].AverageMark, Is.EqualTo(4.8));
        }

        // 2. Тест фильтрации: студенты по типу стипендии
        [Test]
        public void GetStudentsByScholarship_ShouldFilterByScholarshipType()
        {
            // Arrange
            var scholarshipTypeId = 1L; // Академическая

            // Act
            var result = _reportService.GetStudentsByScholarship(scholarshipTypeId);

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.All(s => s.TypeOfScholarship == "Академическая"), Is.True);
        }

        // 3. Тест граничного случая: несуществующий тип стипендии
        [Test]
        public void GetStudentsByScholarship_WithInvalidId_ShouldReturnEmptyList()
        {
            // Arrange
            var invalidTypeId = 999L;

            // Act
            var result = _reportService.GetStudentsByScholarship(invalidTypeId);

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result, Is.Empty);
        }

        // 4. Тест справочника: получение типов стипендий
        [Test]
        public void GetScholarshipTypesForComboBox_ShouldReturnAllTypes()
        {
            // Act
            var result = _reportService.GetScholarshipTypesForComboBox();

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count, Is.EqualTo(3));
            Assert.That(result[0].Name, Is.EqualTo("Академическая"));
            Assert.That(result[1].Name, Is.EqualTo("Повышенная"));
            Assert.That(result[2].Name, Is.EqualTo("Социальная"));
        }

        // 5. Тест вызова зависимостей: проверка что методы репозитория вызываются
        [Test]
        public void ReportMethods_ShouldCallRepositoryMethods()
        {
            // Act
            _reportService.GetTopStudents();
            _reportService.GetStudentsByScholarship(1);
            _reportService.GetScholarshipTypesForComboBox();

            // Assert
            _mockReportRepository.Mock.Verify(r => r.GetTopStudents(), Times.Once);
            _mockReportRepository.Mock.Verify(
                r => r.GetStudentsByScholarship(It.IsAny<long>()), Times.Once);
            _mockReportRepository.Mock.Verify(
                r => r.GetScholarshipTypesForComboBox(), Times.Once);
        }
    }
}