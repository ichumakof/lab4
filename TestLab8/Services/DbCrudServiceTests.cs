using Moq;
using NUnit.Framework;
using BLL.Services;
using DAL.Interfaces;
using DAL;
using BLL.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using TestLab8.Mocks;

namespace TestLab8.Services
{
    [TestFixture]
    public class DbCrudServiceTests
    {
        private MockUnitOfWork _mockUow;
        private DbCrudService _service;

        [SetUp]
        public void Setup()
        {
            _mockUow = new MockUnitOfWork();
            _service = new DbCrudService(_mockUow.Mock.Object);
        }

        [Test]
        public void GetAllStudents_ShouldReturnAllStudents()
        {
            // Arrange
            var expectedCount = 3;

            // Act
            var result = _service.GetAllStudents();

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count, Is.EqualTo(expectedCount));
            Assert.That(result[0].FullName, Is.EqualTo("Иванов Иван Иванович"));
        }

        [Test]
        public void GetStudent_WithExistingId_ShouldReturnStudent()
        {
            // Arrange
            var studentId = 1;

            // Act
            var result = _service.GetStudent(studentId);

            // Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Id, Is.EqualTo(studentId));
            Assert.That(result.FullName, Is.EqualTo("Иванов Иван Иванович"));
        }

        [Test]
        public void CreateStudent_ShouldAddStudentAndSave()
        {
            // Arrange
            var newStudent = new StudentDTO
            {
                FullName = "Новый студент",
                NumOfGradeBook = 99999,
                Course = 4
            };
            var initialCount = _mockUow.StudentsRepository.Data.Count;

            // Act
            _service.CreateStudent(newStudent);

            // Assert
            Assert.That(_mockUow.StudentsRepository.Data.Count,
                Is.EqualTo(initialCount + 1));
            _mockUow.Mock.Verify(u => u.Save(), Times.Once);
        }

        [Test]
        public void CreateMark_WithValidData_ShouldCreateMark()
        {
            // Arrange
            var validMark = new MarkDTO
            {
                Value = 4,
                Semester = 3,
                StudentId = 1
            };

            // Act
            _service.CreateMark(validMark);

            // Assert
            _mockUow.Mock.Verify(u => u.Save(), Times.Once);
        }

        [Test]
        public void CreateMark_WithInvalidValue_ShouldThrowArgumentException()
        {
            // Arrange
            var invalidMark = new MarkDTO
            {
                Value = 1,  // Должно быть 2-5
                Semester = 1,
                StudentId = 1
            };

            // Act & Assert
            Assert.That(
                () => _service.CreateMark(invalidMark),
                Throws.TypeOf<ArgumentException>()
            );
        }
    }
}