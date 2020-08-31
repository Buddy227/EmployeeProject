using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace EmployeeProject
{
    [Table(Name = "Employee")]
    public class EmployeeDB
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id { get; set; }
        [Column]
        public string FIO { get; set; }
        [Column]
        public string post { get; set; }
        [Column]
        public decimal salary { get; set; }
        [Column]
        public DateTime admissionDate { get; set; }
        [Column]
        public string dismissalDate { get; set; }

        public EmployeeDB()
        {
        }
        public EmployeeDB(Employee e)
        {
            if (e == null) return;
            Id = e.Id;
            FIO = e.fio;
            post = e.post;
            salary = e.salary;
            admissionDate = e.admissionDate;
            dismissalDate = (e.dismissalDate == default? "" : e.dismissalDate.ToString());
        }

        public EmployeeDB(emplDataSet1.EmployeeRow x)
        {
        }
    }
    public class Employee
    {
        public int Id { get; set; }
        public string fio { get; set; }
        public string post { get; set; }
        public decimal salary { get; set; }
        public DateTime admissionDate { get; set; }
        public DateTime dismissalDate { get; set; }

        public Employee(string fio, string post, decimal salary, DateTime admissionDate)
        {
            this.fio = fio;
            this.post = post;
            this.salary = salary;
            this.admissionDate = admissionDate;
        }
        public Employee(emplDataSet.EmployeeRow e)
        {
            Id = e.Id;
            fio = e.FIO;
            post = e.post;
            salary = e.salary;
            admissionDate = e.admissionDate;
            dismissalDate = e.dismissalDate;
        }

    }
}
