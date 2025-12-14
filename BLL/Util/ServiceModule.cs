using BLL.Interfaces;
using BLL.Services;
using DAL;
using DAL.Interfaces;
using DAL.Repository;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Util
{
    public class ServiceModule : NinjectModule
    {
        private string connectionString;

        public ServiceModule(string connection)
        {
            connectionString = connection;
        }

        public override void Load()
        {
            // Привязка контекста БД с connection string
            Bind<Students2Entities>().ToSelf().InSingletonScope()
                .WithConstructorArgument("connectionString", connectionString);

            // Привязки сервисов BLL
            Bind<IDbCrud>().To<DbCrudService>();
            Bind<IReportService>().To<ReportService>();
            Bind<IStudentOperations>().To<StudentOperationsService>();

            // Привязки репозиториев DAL
            Bind<IUnitOfWork>().To<UnitOfWork>();
            Bind<IReportRepository>().To<ReportRepository>();
        }
    }
}