using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalFilingProject
{
    class Nurse : Employee
    {
        private int numberOfPatients;

        public int NumberOfPatients
        {
            get { return this.numberOfPatients; }
            set { this.numberOfPatients = value; }
        }

        public Nurse(string employeeName, int employeeNumber, int numberOfPatients)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.numberOfPatients = numberOfPatients;
        }

        public override void PrintStatus()
        {
            Console.Write(this.employeeName + "\t");
            Console.Write(this.employeeNumber + "\t\t\t");
            Console.Write(this.numberOfPatients + "\n");
        }
    }
}
