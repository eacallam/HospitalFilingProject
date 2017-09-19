using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalFilingProject
{
    class Doctor : Employee
    {
        private string specialtyArea;

        public string SpecialityArea
        {
            get { return this.specialtyArea; }
            set { this.specialtyArea = value; }
        }

        public Doctor(string employeeName, int employeeNumber, string specialtyArea)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.specialtyArea = specialtyArea;
        }

        public override void PrintStatus()
        {
            Console.Write(this.employeeName + "\t");
            Console.Write(this.employeeNumber + "\t");
            Console.Write(this.specialtyArea + "\n");
        }
    }
}
