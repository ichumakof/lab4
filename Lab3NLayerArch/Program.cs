using BLL.Util;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Lab3NLayerArch
{
    internal static class Program
    {
        private static IKernel _kernel;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Настройка Ninject
            ConfigureNinject();

            // Запуск главной формы с внедренными зависимостями
            Application.Run(_kernel.Get<MainForm>());
        }

        private static void ConfigureNinject()
        {
            _kernel = new StandardKernel();

            // Получаем connection string из app.config
            string connectionString = System.Configuration.ConfigurationManager
                .ConnectionStrings["Students2Entities"].ConnectionString;

            // Регистрируем модуль с connection string
            _kernel.Load(new ServiceModule(connectionString));
        }
    }
}