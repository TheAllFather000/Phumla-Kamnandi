using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Phumla.Business;
using System.Collections.ObjectModel;
namespace Phumla.Data
{
    public class EmployeeDB : DB
    {
        public static string table = "Employee";
        public static string selectCommand = "SELECT * FROM Employee";
        private Collection<Employee> employees;

        public Collection<Employee> Employees
        {
            get { return employees; }
            set { employees = value; }
        }
        public EmployeeDB() : base()
        {
            employees = new Collection<Employee>();
            Fill(selectCommand, table);
            fillWithEmployee();
        }
        public void fillWithEmployee()
        {
            if (!ds.Tables.Contains(table))
            {
                Fill("SELECT * FROM Employee", "Employee");
            }
            foreach (DataRow row in ds.Tables[table].Rows)
            {
                    Employee a = new Employee();
                    a.EmployeeID = Convert.ToInt64(row["employeeid"]);
                    a.Password = Convert.ToString(row["password_"]);
                    switch (Convert.ToString(row["accesslevel"]))
                    {
                        case "Receptionist":
                            a.Level = Employee.AccessLevel.Receptionist;
                            break;
                        case "Manager":
                            a.Level = Employee.AccessLevel.Manager;
                            break;
                        case "Administrator":
                            a.Level = Employee.AccessLevel.Administrator;
                        break;
                    }
                    Console.WriteLine(a.EmployeeID + " " + a.Password + " " + a.Level);
                    employees.Add(a);
                }
            }
        
        public void changeAccessLevel(long eid, Employee.AccessLevel al)
        {
            foreach (DataRow r in ds.Tables[table].Rows)
            {
                if (eid == Convert.ToInt64(r["employeeid"]))
                {
                    r["accesslevel"] = al;
                    break;
                }
            }
            UpdateDataSource(selectCommand, table);
            Fill(selectCommand, table);
            fillWithEmployee();

        }

        public void changePassword(long eid, string password)
        {
            foreach (DataRow r in ds.Tables[table].Rows)
            {
                if (eid == Convert.ToInt64(r["employeeid"]))
                {
                    r["password_"] = password;
                    break;
                }
            }
             ;
            UpdateDataSource(selectCommand, table);
            Fill(selectCommand, table);
            fillWithEmployee();
        }

        public void AddEmployee(long eid, string password, Employee.AccessLevel al)
        {
            Employee employee = new Employee(eid, password, al);
            DataRow r = ds.Tables[table].NewRow();
            FillRow(r, employee, table, Operation.Add);
            employees.Add(employee);
        }
        public Employee.AccessLevel checkLoginDetails(long eid, string pword)
        {
            Employee.AccessLevel a = Employee.AccessLevel.None;
            foreach (Employee ac in employees)
            {
                
                if (ac.EmployeeID ==  eid && ac.Password == pword)
                {

                    switch ((ac.Level))
                    {
                        case Employee.AccessLevel.Administrator:
                            a = Employee.AccessLevel.Administrator;
                        break;
                        case Employee.AccessLevel.Manager:
                            a = Employee.AccessLevel.Manager;
                        break;
                        case Employee.AccessLevel.Receptionist:
                            a = Employee.AccessLevel.Receptionist;
                        break;
                    }
                    return a;
                }
            }
            return a;
        }

    }
}
