namespace EmployeeProject
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button_addNewEmployee = new System.Windows.Forms.Button();
            this.button_search = new System.Windows.Forms.Button();
            this.button_saveExcel = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.averageSalary = new System.Windows.Forms.Label();
            this.employeeCount = new System.Windows.Forms.Label();
            this.textBox_ID_delete = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Button_delete = new System.Windows.Forms.Button();
            this.emplDataSet = new EmployeeProject.emplDataSet();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new EmployeeProject.emplDataSetTableAdapters.EmployeeTableAdapter();
            this.tableAdapterManager = new EmployeeProject.emplDataSetTableAdapters.TableAdapterManager();
            this.button_dismissEmployee = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_ID_Dismiss = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker_dismiss = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.emplDataSet1 = new EmployeeProject.emplDataSet1();
            this.employeeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter1 = new EmployeeProject.emplDataSet1TableAdapters.EmployeeTableAdapter();
            this.tableAdapterManager1 = new EmployeeProject.emplDataSet1TableAdapters.TableAdapterManager();
            this.employeeDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_saveXml = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.emplDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emplDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_addNewEmployee
            // 
            this.button_addNewEmployee.Location = new System.Drawing.Point(12, 12);
            this.button_addNewEmployee.Name = "button_addNewEmployee";
            this.button_addNewEmployee.Size = new System.Drawing.Size(110, 66);
            this.button_addNewEmployee.TabIndex = 0;
            this.button_addNewEmployee.Text = "Добавить сотрудника";
            this.button_addNewEmployee.UseVisualStyleBackColor = true;
            this.button_addNewEmployee.Click += new System.EventHandler(this.button_addNewEmployee_Click);
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(588, 55);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(172, 23);
            this.button_search.TabIndex = 1;
            this.button_search.Text = "Найти";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // button_saveExcel
            // 
            this.button_saveExcel.Location = new System.Drawing.Point(662, 483);
            this.button_saveExcel.Name = "button_saveExcel";
            this.button_saveExcel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_saveExcel.Size = new System.Drawing.Size(110, 66);
            this.button_saveExcel.TabIndex = 2;
            this.button_saveExcel.Text = "Сохранить excel";
            this.button_saveExcel.UseVisualStyleBackColor = true;
            this.button_saveExcel.Click += new System.EventHandler(this.button_saveExcel_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(588, 28);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 21);
            this.textBox1.TabIndex = 5;
            // 
            // averageSalary
            // 
            this.averageSalary.AutoSize = true;
            this.averageSalary.Location = new System.Drawing.Point(87, 483);
            this.averageSalary.Name = "averageSalary";
            this.averageSalary.Size = new System.Drawing.Size(75, 13);
            this.averageSalary.TabIndex = 6;
            this.averageSalary.Text = "averageSalary";
            // 
            // employeeCount
            // 
            this.employeeCount.AutoSize = true;
            this.employeeCount.Location = new System.Drawing.Point(87, 523);
            this.employeeCount.Name = "employeeCount";
            this.employeeCount.Size = new System.Drawing.Size(80, 13);
            this.employeeCount.TabIndex = 7;
            this.employeeCount.Text = "employeeCount";
            // 
            // textBox_ID_delete
            // 
            this.textBox_ID_delete.Location = new System.Drawing.Point(162, 29);
            this.textBox_ID_delete.Name = "textBox_ID_delete";
            this.textBox_ID_delete.Size = new System.Drawing.Size(87, 20);
            this.textBox_ID_delete.TabIndex = 8;
            this.textBox_ID_delete.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_ID_delete_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Удалить сотрудника";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "ID";
            // 
            // Button_delete
            // 
            this.Button_delete.Location = new System.Drawing.Point(141, 59);
            this.Button_delete.Name = "Button_delete";
            this.Button_delete.Size = new System.Drawing.Size(108, 24);
            this.Button_delete.TabIndex = 11;
            this.Button_delete.Text = "Удалить";
            this.Button_delete.UseVisualStyleBackColor = true;
            this.Button_delete.Click += new System.EventHandler(this.Button_delete_Click);
            // 
            // emplDataSet
            // 
            this.emplDataSet.DataSetName = "emplDataSet";
            this.emplDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.emplDataSet;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmployeeTableAdapter = this.employeeTableAdapter;
            this.tableAdapterManager.UpdateOrder = EmployeeProject.emplDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // button_dismissEmployee
            // 
            this.button_dismissEmployee.Location = new System.Drawing.Point(272, 90);
            this.button_dismissEmployee.Name = "button_dismissEmployee";
            this.button_dismissEmployee.Size = new System.Drawing.Size(233, 23);
            this.button_dismissEmployee.TabIndex = 16;
            this.button_dismissEmployee.Text = "Уволить";
            this.button_dismissEmployee.UseVisualStyleBackColor = true;
            this.button_dismissEmployee.Click += new System.EventHandler(this.button_dismissEmployee_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Уволить сотрудника";
            // 
            // textBox_ID_Dismiss
            // 
            this.textBox_ID_Dismiss.Location = new System.Drawing.Point(367, 29);
            this.textBox_ID_Dismiss.Name = "textBox_ID_Dismiss";
            this.textBox_ID_Dismiss.Size = new System.Drawing.Size(138, 20);
            this.textBox_ID_Dismiss.TabIndex = 13;
            this.textBox_ID_Dismiss.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_ID_Dismiss_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "дата увольнения";
            // 
            // dateTimePicker_dismiss
            // 
            this.dateTimePicker_dismiss.Location = new System.Drawing.Point(367, 59);
            this.dateTimePicker_dismiss.Name = "dateTimePicker_dismiss";
            this.dateTimePicker_dismiss.Size = new System.Drawing.Size(138, 20);
            this.dateTimePicker_dismiss.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(659, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Поиск";
            // 
            // emplDataSet1
            // 
            this.emplDataSet1.DataSetName = "emplDataSet1";
            this.emplDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeBindingSource1
            // 
            this.employeeBindingSource1.DataMember = "Employee";
            this.employeeBindingSource1.DataSource = this.emplDataSet1;
            // 
            // employeeTableAdapter1
            // 
            this.employeeTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.EmployeeTableAdapter = this.employeeTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = EmployeeProject.emplDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // employeeDataGridView1
            // 
            this.employeeDataGridView1.AutoGenerateColumns = false;
            this.employeeDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.employeeDataGridView1.DataSource = this.employeeBindingSource1;
            this.employeeDataGridView1.Location = new System.Drawing.Point(38, 141);
            this.employeeDataGridView1.Name = "employeeDataGridView1";
            this.employeeDataGridView1.ReadOnly = true;
            this.employeeDataGridView1.Size = new System.Drawing.Size(722, 312);
            this.employeeDataGridView1.TabIndex = 19;
            this.employeeDataGridView1.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeDataGridView_CellValidated);
            this.employeeDataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.employeeDataGridView_CellValidating);
            this.employeeDataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.employeeDataGridView_DataError);
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn7.HeaderText = "Id";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "FIO";
            this.dataGridViewTextBoxColumn8.HeaderText = "FIO";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "post";
            this.dataGridViewTextBoxColumn9.HeaderText = "post";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "salary";
            this.dataGridViewTextBoxColumn10.HeaderText = "salary";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "admissionDate";
            this.dataGridViewTextBoxColumn11.HeaderText = "admissionDate";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "dismissalDate";
            this.dataGridViewTextBoxColumn12.HeaderText = "dismissalDate";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // button_saveXml
            // 
            this.button_saveXml.Location = new System.Drawing.Point(546, 483);
            this.button_saveXml.Name = "button_saveXml";
            this.button_saveXml.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_saveXml.Size = new System.Drawing.Size(110, 66);
            this.button_saveXml.TabIndex = 20;
            this.button_saveXml.Text = "Сохранить xml";
            this.button_saveXml.UseVisualStyleBackColor = true;
            this.button_saveXml.Click += new System.EventHandler(this.button_saveXml_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 569);
            this.Controls.Add(this.button_saveXml);
            this.Controls.Add(this.employeeDataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker_dismiss);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_dismissEmployee);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_ID_Dismiss);
            this.Controls.Add(this.Button_delete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_ID_delete);
            this.Controls.Add(this.employeeCount);
            this.Controls.Add(this.averageSalary);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_saveExcel);
            this.Controls.Add(this.button_search);
            this.Controls.Add(this.button_addNewEmployee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Учёт сотрудников";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.emplDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emplDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_addNewEmployee;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button_saveExcel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label averageSalary;
        private System.Windows.Forms.Label employeeCount;
        private System.Windows.Forms.TextBox textBox_ID_delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Button_delete;
        private emplDataSet emplDataSet;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private emplDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private emplDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button button_dismissEmployee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_ID_Dismiss;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dismiss;
        private System.Windows.Forms.Label label6;
        private emplDataSet1 emplDataSet1;
        private System.Windows.Forms.BindingSource employeeBindingSource1;
        private emplDataSet1TableAdapters.EmployeeTableAdapter employeeTableAdapter1;
        private emplDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView employeeDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.Button button_saveXml;
    }
}

