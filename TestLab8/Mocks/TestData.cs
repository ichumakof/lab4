using DAL;
using DAL.Interfaces;
using System.Collections.Generic;

namespace TestLab8.Mocks
{
    public static class TestData
    {
        public static List<Students> GetStudents()
        {
            return new List<Students>
            {
                new Students
                {
                    Id = 1,
                    full_name = "Иванов Иван Иванович",
                    num_of_grade_book = 12345,
                    course = 2
                },
                new Students
                {
                    Id = 2,
                    full_name = "Петров Петр Петрович",
                    num_of_grade_book = 12346,
                    course = 3
                },
                new Students
                {
                    Id = 3,
                    full_name = "Сидорова Анна Сергеевна",
                    num_of_grade_book = 12347,
                    course = 1
                }
            };
        }

        public static List<Marks> GetMarks()
        {
            return new List<Marks>
            {
                new Marks { Id = 1, value = 5, semester = 1, Id_of_Student_FK_ = 1 },
                new Marks { Id = 2, value = 4, semester = 1, Id_of_Student_FK_ = 1 },
                new Marks { Id = 3, value = 3, semester = 2, Id_of_Student_FK_ = 2 },
                new Marks { Id = 4, value = 5, semester = 2, Id_of_Student_FK_ = 3 }
            };
        }

        public static List<TopStudentInfo> GetTopStudents()
        {
            return new List<TopStudentInfo>
            {
                new TopStudentInfo { FullName = "Иванов И.И.", AverageMark = 4.8 },
                new TopStudentInfo { FullName = "Петров П.П.", AverageMark = 4.6 },
                new TopStudentInfo { FullName = "Сидорова А.С.", AverageMark = 4.9 }
            };
        }

        public static List<ScholarshipInfo> GetScholarshipStudents()
        {
            return new List<ScholarshipInfo>
            {
                new ScholarshipInfo
                {
                    FullName = "Иванов И.И.",
                    NumOfGradeBook = 12345,
                    Course = 2,
                    TypeOfScholarship = "Академическая"
                },
                new ScholarshipInfo
                {
                    FullName = "Петров П.П.",
                    NumOfGradeBook = 12346,
                    Course = 3,
                    TypeOfScholarship = "Повышенная"
                }
            };
        }

        public static List<ScholarshipTypeInfo> GetScholarshipTypes()
        {
            return new List<ScholarshipTypeInfo>
            {
                new ScholarshipTypeInfo { Id_type_of_scholarship = 1, Name = "Академическая" },
                new ScholarshipTypeInfo { Id_type_of_scholarship = 2, Name = "Повышенная" },
                new ScholarshipTypeInfo { Id_type_of_scholarship = 3, Name = "Социальная" }
            };
        }
    }
}