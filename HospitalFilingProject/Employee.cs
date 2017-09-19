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

        //METHODS
        public virtual void PrintStatus() //don't need to add any action here because won't be calling this particular method
        {
            
        }

        
    }
}
