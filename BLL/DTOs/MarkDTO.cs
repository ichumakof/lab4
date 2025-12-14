using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class MarkDTO
    {
        public int Id { get; set; }
        public int? Value { get; set; }
        public int? Semester { get; set; }

        // Навигационные свойства для отображения
        public string StudentName { get; set; }

        public int? StudentId { get; set; }
    }
}
