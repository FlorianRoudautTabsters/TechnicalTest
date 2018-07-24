namespace TechnicalTest
{
    partial class ToDoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listViewTasks = new System.Windows.Forms.ListView();
            this.buttonShowDefaultEmployee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewTasks
            // 
            this.listViewTasks.Location = new System.Drawing.Point(0, 2);
            this.listViewTasks.Name = "listViewTasks";
            this.listViewTasks.Size = new System.Drawing.Size(284, 197);
            this.listViewTasks.TabIndex = 0;
            this.listViewTasks.UseCompatibleStateImageBehavior = false;
            // 
            // buttonShowDefaultEmployee
            // 
            this.buttonShowDefaultEmployee.Location = new System.Drawing.Point(12, 205);
            this.buttonShowDefaultEmployee.Name = "buttonShowDefaultEmployee";
            this.buttonShowDefaultEmployee.Size = new System.Drawing.Size(178, 23);
            this.buttonShowDefaultEmployee.TabIndex = 1;
            this.buttonShowDefaultEmployee.Text = "Show Default Employee";
            this.buttonShowDefaultEmployee.UseVisualStyleBackColor = true;
            this.buttonShowDefaultEmployee.Click += new System.EventHandler(this.buttonShowDefaultEmployee_Click);
            // 
            // ToDoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.buttonShowDefaultEmployee);
            this.Controls.Add(this.listViewTasks);
            this.Name = "ToDoForm";
            this.Text = "To Do";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewTasks;
        private System.Windows.Forms.Button buttonShowDefaultEmployee;
    }
}

