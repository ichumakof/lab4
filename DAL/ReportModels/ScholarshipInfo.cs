using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ReportModels
{
    internal class ScholarshipInfo
    {
        public string FullName { get; set; }
        public int? NumOfGradeBook { get; set; }
        public int? Course { get; set; }
        public string TypeOfScholarship { get; set; }
    }
}
