using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public partial class Students2Entities
    {
        // ДОБАВЛЯЕМ КОНСТРУКТОР ДЛЯ ПРИЕМА CONNECTION STRING
        public Students2Entities(string connectionString)
            : base(connectionString)
        {
        }
    }
}
