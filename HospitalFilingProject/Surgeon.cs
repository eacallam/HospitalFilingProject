using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalFilingProject
{
    class Surgeon : Employee
    {
        private string specialtyArea;
        private bool isOperating;

        public string SpecialtyArea
        {
            get { return this.specialtyArea;  }
            set { specialtyArea = value; }
        }

        public bool IsOperating
        {
            get { return this.isOperating; }
            set { isOperating = value; }
        }

        public Surgeon(string employeeName, int employeeNumber, string specialtyArea, bool isOperating)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.specialtyArea = specialtyArea;
            this.isOperating = isOperating;
        }

        public override void PrintStatus()
        {
            Console.Write(this.employeeName + "\t");
            Console.Write(this.employeeNumber + "\t");
            Console.Write(this.specialtyArea + "\t");
            Console.Write(this.isOperating + "\n");
        }

        public void OperatingStatus()
        {
            if (this.isOperating == true)
            {
                Console.WriteLine(this.employeeName + " is operating now.");
            }

            else
            {
                Console.WriteLine(this.employeeName + " is not operating now.");
            }
        }
    }
}
