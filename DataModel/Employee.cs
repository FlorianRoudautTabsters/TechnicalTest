using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalTest.DataModel
{
    public class Employee
    {
        public Employee()
        {
            Tasks = new List<Task>();
        }

        public static Employee Default()
        {
            var defaultEmployee = new Employee();
            defaultEmployee.Id = -1;
            defaultEmployee.Name = "Steve Jobs";

            var firstTask = new Task();
            firstTask.TaskId = 1;
            firstTask.TaskName = "Create iPod";
            firstTask.DueDate = new DateTime(2001, 10, 01);
            firstTask.AssignedEmployeeId = defaultEmployee.Id;
            defaultEmployee.Tasks.Add(firstTask);

            var secondTask = new Task();
            secondTask.TaskId = 2;
            secondTask.TaskName = "Create iPhone";
            secondTask.DueDate = new DateTime(2007, 06, 29);
            secondTask.AssignedEmployeeId = defaultEmployee.Id;
            defaultEmployee.Tasks.Add(secondTask);

            var thirdTask = new Task();
            thirdTask.TaskId = 1;
            thirdTask.TaskName = "Create MacBook";
            thirdTask.DueDate = new DateTime(2006, 06, 16);
            thirdTask.AssignedEmployeeId = defaultEmployee.Id;
            defaultEmployee.Tasks.Add(thirdTask);

            return defaultEmployee;
        }
        public long Id { get; set; }
        public string Name { get; set; }

        public List<Task> Tasks { get; set; }
    }
}
