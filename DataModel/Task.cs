using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalTest.DataModel
{
    public class Task
    {
        public long TaskId { get; set; }
        public string TaskName { get; set; }

        public DateTime DueDate { get; set; }

        public long AssignedEmployeeId { get; set; }
    }
}
