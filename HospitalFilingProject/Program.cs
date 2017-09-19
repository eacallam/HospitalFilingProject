using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalFilingProject
{
    class Program
    {
        public void EmployeeDatabase()
        {        
            Console.WriteLine("High St. Hospital Employees");
            
        }

        static void Main(string[] args)
        {         
            Doctor newDoctor = new Doctor("David", 100001, "Pediatrics");
            Surgeon newSurgeon = new Surgeon("Max", 100003, "Podiatry", true);
            Nurse newNurse = new Nurse("Marg", 100004, 4);
            Administrator newAdministrator = new Administrator("Paula", 100005, "Finance");
            Receptionist newReceptionist = new Receptionist("Melanie", 100006, "HR", false);
            Janitor newJanitor = new Janitor("Tim", 100007, "Maintenance", true);

            newDoctor.PrintStatus();
            newSurgeon.PrintStatus();
            newNurse.PrintStatus();
            newAdministrator.PrintStatus();
            newReceptionist.PrintStatus();
            newJanitor.PrintStatus();

            newJanitor.SweepingStatus();
            newReceptionist.PhoneStatus();
            newSurgeon.OperatingStatus();

            //CREATING AND OBJECT LIST
            List<Employee> employeeDatabase = new List<Employee>() { newDoctor, newSurgeon, newNurse, newAdministrator, newReceptionist, newJanitor };
             
        }


        
    }
}
