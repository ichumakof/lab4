using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class StudentDTO
    {
        // Для таблицы на основной форме
        public int Id { get; set; }
        public string FullName { get; set; }
        public int? NumOfGradeBook { get; set; }

        // ТОЛЬКО для формы редактирования
        public int? Course { get; set; }
    }
}
