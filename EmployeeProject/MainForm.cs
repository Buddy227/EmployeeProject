using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Serialization;
using Microsoft.Office.Core;
using MoreLinq;

namespace EmployeeProject
{

    public partial class MainForm : Form
    {

        private static string path = System.IO.Directory.GetCurrentDirectory();
        private static string path1 = System.IO.Directory.GetParent(path).ToString();
        private static string path2 = System.IO.Directory.GetParent(path1).ToString();

        private static string connectionString = @"Data Source=(localDB)\MSSQLLocalDB;AttachDbFilename=" + path2 +
                                                 @"\empl.mdf;Integrated Security=True";

        public MainForm()
        {
            InitializeComponent();
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.emplDataSet1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // TODO: данная строка кода позволяет загрузить данные в таблицу "emplDataSet1.Employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter1.Fill(this.emplDataSet1.Employee);

            UpdateStatistic();
        }

        private void UpdateStatistic(List<EmployeeDB> list = null)
        {
            if (list != null)
            {
                employeeCount.Text = "Количество сотрудников:\t" +
                                     list.Where(x => x.dismissalDate == "").Count().ToString();
                averageSalary.Text = "Средний оклад:\t" +
                                     list.Where(x => x.dismissalDate == "").Average(x => x.salary).ToString();
            }
            else
            {
                var employeeList =
                    (from x in emplDataSet1.Employee
                     where (x.post != null && x.dismissalDate.ToString() != null)
                     select x)
                    .ToList();
                employeeCount.Text = "Количество сотрудников:\t" + employeeList.Count();
                averageSalary.Text = "Средний оклад:\t" +
                                     (employeeList.Count() > 0 ? employeeList.Average(x => x.salary) : 0);
            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            employeeDataGridView1.DefaultCellStyle.BackColor = Color.White;
            for (int i = 0; i < employeeDataGridView1.RowCount; i++)
            {
                employeeDataGridView1.Rows[i].Selected = false;
                for (int j = 0; j < employeeDataGridView1.ColumnCount; j++)
                    if (employeeDataGridView1.Rows[i].Cells[j].Value != null)
                        if (employeeDataGridView1.Rows[i].Cells[j].Value.ToString().Contains(textBox1.Text))
                        {
                            employeeDataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                            employeeDataGridView1.Rows[i].Selected = true;
                            break;
                        }
            }
        }

        private void button_addNewEmployee_Click(object sender, EventArgs e)
        {

            var resultAdd = new addEmployeeForm();
            resultAdd.ShowDialog();
            if (resultAdd.DialogResult == DialogResult.OK)
            {
                using (var db = new DataContext(connectionString))
                {
                    var table = db.GetTable<EmployeeDB>();
                    var user = new EmployeeDB(resultAdd.newEmployee);
                    table.InsertOnSubmit(user);
                    db.SubmitChanges();
                    employeeDataGridView1.DataSource = table;
                    UpdateStatistic(table.ToList());
                }
            }
        }


        private void Button_delete_Click(object sender, EventArgs e)
        {
            using (var db = new DataContext(connectionString))
            {
                var table = db.GetTable<EmployeeDB>();
                var user = table.FirstOrDefault(x => x.Id == Convert.ToInt32(textBox_ID_delete.Text));
                if (user != null)
                {
                    table.DeleteOnSubmit(user);
                    db.SubmitChanges();
                    employeeDataGridView1.DataSource = table;
                }
                UpdateStatistic(table.ToList());
            }
        }

        private void textBox_ID_delete_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ((char)8))
            {
                e.Handled = true;
            }
        }

        private void EmployeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.emplDataSet1);
        }

        private void employeeDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("В строке " + e.RowIndex + " колонке " + e.ColumnIndex + " некорректное значение.");
        }

        private void employeeDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.FormattedValue.ToString().Contains("-"))
            {
                MessageBox.Show("Оклад не может быть отрицательным.");
                e.Cancel = true;
            }
        }

        private void employeeDataGridView_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            employeeDataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = null;
        }

        private void button_dismissEmployee_Click(object sender, EventArgs e)
        {

            using (var db = new DataContext(connectionString))
            {
                var table = db.GetTable<EmployeeDB>();
                var user = table.FirstOrDefault(x => x.Id == Convert.ToInt32(textBox_ID_Dismiss.Text));
                if (user != null)
                {
                    user.dismissalDate = dateTimePicker_dismiss.Value.ToString();
                    if (DateTime.Parse(user.dismissalDate) >= user.admissionDate)
                    {
                        db.SubmitChanges();
                        employeeDataGridView1.DataSource = table;
                    }
                    else
                    {
                        MessageBox.Show("Дата увольнения раньше даты приема на работу?");
                    }
                }

                UpdateStatistic(table.ToList());
            }
        }

        private void textBox_ID_Dismiss_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ((char)8))
            {
                e.Handled = true;
            }
        }

        private void button_saveExcel_Click(object sender, EventArgs e)
        {
            using (var db = new DataContext(connectionString))
            {
                var table = db.GetTable<EmployeeDB>().ToList().ToDataTable();
                var saveDialog = new SaveFileDialog();
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    My_DataTable_Extensions.ExportToExcel(table, saveDialog.FileName);
                }
            }
        }
        private void button_saveXml_Click(object sender, EventArgs e)
        {

            using (var db = new DataContext(connectionString))
            {

                var table = db.GetTable<EmployeeDB>();
                XmlSerializer xml = new XmlSerializer(typeof(List<EmployeeDB>));
                var saveDialog = new SaveFileDialog();
                List<EmployeeDB> list = new List<EmployeeDB>();
                if (saveDialog.ShowDialog() == DialogResult.OK)
                {

                    foreach (var element in table)
                    {
                        list.Add(element);
                    }
                    using (StreamWriter newFile = new StreamWriter(saveDialog.FileName))
                    {
                        xml.Serialize(newFile, list);
                    }

                }
            }
        }
    }


    public static class My_DataTable_Extensions
    {
        public static void ExportToExcel(this DataTable table, string excelFilePath = null)
        {
            try
            {
                if (table == null || table.Columns.Count == 0)
                    throw new Exception("Вы пытаетесь сохранить пустую таблицу\n");

                var excelApp = new Microsoft.Office.Interop.Excel.Application();
                excelApp.Workbooks.Add();

                Microsoft.Office.Interop.Excel._Worksheet workSheet = excelApp.ActiveSheet;

                for (var i = 0; i < table.Columns.Count; i++)
                {
                    workSheet.Cells[1, i + 1] = table.Columns[i].ColumnName;
                }

                for (var i = 0; i < table.Rows.Count; i++)
                {

                    for (var j = 0; j < table.Columns.Count; j++)
                    {
                        workSheet.Cells[i + 2, j + 1] = table.Rows[i][j];
                    }
                }

                if (!string.IsNullOrEmpty(excelFilePath))
                {
                    try
                    {
                        workSheet.SaveAs(excelFilePath);
                        excelApp.Quit();
                        MessageBox.Show("Файл успешно создан!");
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Файл не может быть создан. Проверьте правильность путь файла.\n"
                                            + ex.Message);
                    }
                }
                else
                {
                    excelApp.Visible = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("ExportToExcel: \n" + ex.Message);
            }
        }

    }
}