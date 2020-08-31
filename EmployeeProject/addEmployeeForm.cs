using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeProject
{
    public partial class addEmployeeForm : Form
    {
        public Employee newEmployee { get; set; }
    
        public addEmployeeForm()
        {
            InitializeComponent();
        }

        private void button_addNewEmployee_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBox_FIO.Text))
            {
                MessageBox.Show("Не должно быть пустых полей, пожалуйста заполните полностью всю форму.");

            }

            if (string.IsNullOrEmpty(textBox_post.Text))
            {
                MessageBox.Show("Не заполнена должность нового сотрудника");

            }

            if (numericUpDown_salary.Value <= 0)
            {
                MessageBox.Show("Проверьте указанную зарплату нового сотрудника");

            }

            if (dateTimePicker_admission_date.Text == "")
            {
                MessageBox.Show("Не выбрана дата приёма на работу");

            }

            if (dateTimePicker_admission_date.Value.Date > DateTime.Now)
            {
                MessageBox.Show("Указана дата в будущем времени!!!");

            }

            newEmployee = new Employee(textBox_FIO.Text, textBox_post.Text, numericUpDown_salary.Value, dateTimePicker_admission_date.Value);
            Close();
        }

        private void textBox_FIO_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_FIO.Text) || string.IsNullOrEmpty(textBox_post.Text) || numericUpDown_salary.Value == 0)
                button_addNewEmployee.Enabled = false;
            else button_addNewEmployee.Enabled = true;
        }

        private void textBox_post_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_FIO.Text) || string.IsNullOrEmpty(textBox_post.Text) || numericUpDown_salary.Value == 0)
                button_addNewEmployee.Enabled = false;
            else button_addNewEmployee.Enabled = true;
        }

        private void numericUpDown_salary_ValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_FIO.Text) || string.IsNullOrEmpty(textBox_post.Text) || numericUpDown_salary.Value == 0)
                button_addNewEmployee.Enabled = false;
            else button_addNewEmployee.Enabled = true;
        }
    }
}
