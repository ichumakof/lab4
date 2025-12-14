using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Students> Students { get; }
        IRepository<Marks> Marks { get; }
        IReportRepository Reports { get; }
        void Save();
    }
}
