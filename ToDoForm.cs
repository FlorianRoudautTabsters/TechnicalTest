using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechnicalTest.DataModel;

namespace TechnicalTest
{
    public partial class ToDoForm : Form
    {
        public ToDoForm()
        {
            InitializeComponent();

            listViewTasks.View = View.Details;
            listViewTasks.GridLines = true;
            listViewTasks.FullRowSelect = true;


            listViewTasks.Columns.Add("TaskName",100);
            listViewTasks.Columns.Add("DueDate",100);
        }

        private void buttonShowDefaultEmployee_Click(object sender, EventArgs e)
        {
            listViewTasks.Items.Clear();
            var defaultEmployee = Employee.Default();
            foreach(var task in defaultEmployee.Tasks)
            {
                var arr = new string[2];
                ListViewItem itm;
                //add items to 
                arr[0] = task.TaskName;
                arr[1] = task.DueDate.ToShortDateString();
                itm = new ListViewItem(arr);
                listViewTasks.Items.Add(itm);
            }
        }
    }
}
