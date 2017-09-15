using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalFilingProject
{
    class Janitor : Employee
    {
        private string department;
        private bool isSweeping;

        public string Department
        {
            get { return this.department; }
            set { this.department = value; }
        }

        public bool IsSweeping
        {
            get { return this.isSweeping; }
            set { this.isSweeping = value; }
        }

        public Janitor(string employeeName, int employeeNumber, string department, bool isSweeping)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.department = department;
            this.isSweeping = isSweeping;
        }

    }
}
