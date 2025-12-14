using DAL;
using DAL.Interfaces;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace TestLab8.Mocks
{
    public class MockRepository<T> where T : class
    {
        public Mock<IRepository<T>> Mock { get; }
        public List<T> Data { get; set; }

        public MockRepository(List<T> initialData = null)
        {
            Mock = new Mock<IRepository<T>>();
            Data = initialData ?? new List<T>();

            ConfigureMock();
        }

        private void ConfigureMock()
        {
            // GetAll()
            Mock.Setup(r => r.GetAll())
                .Returns(Data.AsQueryable());

            // GetById(id)
            Mock.Setup(r => r.GetById(It.IsAny<int>()))
                .Returns<int>(id => FindById(id));

            // Add(entity)
            Mock.Setup(r => r.Add(It.IsAny<T>()))
                .Callback<T>(entity => Data.Add(entity));

            // Update(entity)
            Mock.Setup(r => r.Update(It.IsAny<T>()))
                .Callback<T>(entity =>
                {
                    // Простая замена по индексу 0 (для тестов достаточно)
                    if (Data.Count > 0) Data[0] = entity;
                });

            // Delete(entity)
            Mock.Setup(r => r.Delete(It.IsAny<T>()))
                .Callback<T>(entity =>
                {
                    if (Data.Count > 0) Data.RemoveAt(0);
                });
        }

        private T FindById(int id)
        {
            // Простой поиск для Students и Marks
            if (typeof(T) == typeof(Students))
            {
                return Data.FirstOrDefault(e => ((Students)(object)e).Id == id) as T;
            }
            else if (typeof(T) == typeof(Marks))
            {
                return Data.FirstOrDefault(e => ((Marks)(object)e).Id == id) as T;
            }

            return Data.FirstOrDefault();
        }
    }
}