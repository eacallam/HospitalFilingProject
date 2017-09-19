using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalFilingProject
{
    class Receptionist : Employee
    {
        private string department;
        private bool onPhone;

        public string Department
        {
            get { return this.department; }
            set { department = value; }
        }

        public bool OnPhone
        {
            get { return this.onPhone; }
            set { onPhone = value; }
        }

        public Receptionist(string employeeName, int employeeNumber, string department, bool onPhone)
        {
            this.employeeName = employeeName;
            this.employeeNumber = employeeNumber;
            this.department = department;
            this.onPhone = onPhone;
        }

        public override void PrintStatus()
        {
            Console.Write(this.employeeName + "\t");
            Console.Write(this.employeeNumber + "\t");
            Console.Write(this.department + "\t\t");
            Console.Write(this.onPhone + "\n");
        }

        public void PhoneStatus()
        {
            if (this.onPhone == true)
            {
                Console.WriteLine(this.employeeName + " is on the phone now.");
            }

            else
            {
                Console.WriteLine(this.employeeName + " is not on the phone now.");
            }
        }

    }
}
