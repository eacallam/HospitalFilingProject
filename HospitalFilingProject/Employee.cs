using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalFilingProject
{
    class Employee
    {
        //FIELDS
        protected string employeeName;
        protected int employeeNumber;


        //PROPERTIES
        public string EmployeeName
        {
            get { return this.employeeName; }
        }

        public int EmployeeNumber
        {
            get { return this.employeeNumber; }
        }

        //CONSTRUCTORS
        public Employee()
        {

        }

        public Employee(string employeeName, int employeeNumber)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
        }
    }
}
