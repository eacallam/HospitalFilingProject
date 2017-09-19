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

        public override void PrintStatus()
        {
            Console.Write(this.employeeName + "\t");
            Console.Write(this.employeeNumber + "\t");
            Console.Write(this.department + "\t");
            Console.Write(this.isSweeping + "\n");
        }

        public void SweepingStatus()
        {
            if (this.isSweeping == true)
            {
                Console.WriteLine(this.employeeName + " is sweeping now.");
            }

            else
            {
                Console.WriteLine(this.employeeName + " is not sweeping now.");
            }
        }

    }
}
