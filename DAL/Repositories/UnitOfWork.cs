using DAL.Interfaces;
using DAL.Repositories;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Students2Entities _context;

        public IRepository<Students> Students { get; private set; }
        public IRepository<Marks> Marks { get; private set; }
        public IReportRepository Reports { get; private set; }

        public UnitOfWork(Students2Entities context)
        {
            _context = context;
            Students = new Repository<Students>(_context);
            Marks = new Repository<Marks>(_context);
            Reports = new ReportRepository(_context);
        }
        public void Dispose() => _context?.Dispose();
        public void Save() => _context.SaveChanges();
    }
}