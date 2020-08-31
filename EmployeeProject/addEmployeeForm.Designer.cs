namespace EmployeeProject
{
    partial class addEmployeeForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_FIO = new System.Windows.Forms.TextBox();
            this.textBox_post = new System.Windows.Forms.TextBox();
            this.dateTimePicker_admission_date = new System.Windows.Forms.DateTimePicker();
            this.button_addNewEmployee = new System.Windows.Forms.Button();
            this.numericUpDown_salary = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_salary)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Должность";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Зарплата";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Дата приёма на работу";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(318, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "рублей";
            // 
            // textBox_FIO
            // 
            this.textBox_FIO.Location = new System.Drawing.Point(172, 75);
            this.textBox_FIO.Name = "textBox_FIO";
            this.textBox_FIO.Size = new System.Drawing.Size(140, 20);
            this.textBox_FIO.TabIndex = 5;
            this.textBox_FIO.TextChanged += new System.EventHandler(this.textBox_FIO_TextChanged);
            // 
            // textBox_post
            // 
            this.textBox_post.Location = new System.Drawing.Point(172, 118);
            this.textBox_post.Name = "textBox_post";
            this.textBox_post.Size = new System.Drawing.Size(140, 20);
            this.textBox_post.TabIndex = 6;
            this.textBox_post.TextChanged += new System.EventHandler(this.textBox_post_TextChanged);
            // 
            // dateTimePicker_admission_date
            // 
            this.dateTimePicker_admission_date.Location = new System.Drawing.Point(172, 221);
            this.dateTimePicker_admission_date.Name = "dateTimePicker_admission_date";
            this.dateTimePicker_admission_date.Size = new System.Drawing.Size(140, 20);
            this.dateTimePicker_admission_date.TabIndex = 7;
            // 
            // button_addNewEmployee
            // 
            this.button_addNewEmployee.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_addNewEmployee.Enabled = false;
            this.button_addNewEmployee.Location = new System.Drawing.Point(275, 300);
            this.button_addNewEmployee.Name = "button_addNewEmployee";
            this.button_addNewEmployee.Size = new System.Drawing.Size(100, 50);
            this.button_addNewEmployee.TabIndex = 8;
            this.button_addNewEmployee.Text = "Добавить";
            this.button_addNewEmployee.UseVisualStyleBackColor = true;
            this.button_addNewEmployee.Click += new System.EventHandler(this.button_addNewEmployee_Click);
            // 
            // numericUpDown_salary
            // 
            this.numericUpDown_salary.Location = new System.Drawing.Point(172, 168);
            this.numericUpDown_salary.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numericUpDown_salary.Name = "numericUpDown_salary";
            this.numericUpDown_salary.Size = new System.Drawing.Size(140, 20);
            this.numericUpDown_salary.TabIndex = 9;
            this.numericUpDown_salary.ValueChanged += new System.EventHandler(this.numericUpDown_salary_ValueChanged);
            // 
            // addEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.numericUpDown_salary);
            this.Controls.Add(this.button_addNewEmployee);
            this.Controls.Add(this.dateTimePicker_admission_date);
            this.Controls.Add(this.textBox_post);
            this.Controls.Add(this.textBox_FIO);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "addEmployeeForm";
            this.Text = "Добавление сотрудника";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_salary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_FIO;
        private System.Windows.Forms.TextBox textBox_post;
        private System.Windows.Forms.DateTimePicker dateTimePicker_admission_date;
        private System.Windows.Forms.Button button_addNewEmployee;
        private System.Windows.Forms.NumericUpDown numericUpDown_salary;
    }
}