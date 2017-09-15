using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalFilingProject
{
    class Administrator : Employee
    {
        private string department;

        public string Department
        {
            get { return this.department; }
            set { this.department = value; }
        }

        public Administrator(string employeeName, int employeeNumber, string department)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.department = department;
        }



    }
}
