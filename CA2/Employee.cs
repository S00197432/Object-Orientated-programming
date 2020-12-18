using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA2
{
     public class Employee
     {
        public string FirstName { get; set; }
        public string SureName { get; set; }
        public string TypeOfEmployee { get; set; }
        public string HourlyRate { get; set; }
        public string HoursWorked { get; set; }
        public string Salary { get; set; }



        //public string FullTime { get; set; }

        public Employee(string firstname,string surename, string typeOfEmployee,string hourlyRate, string hoursWorked, string salary)
        {
            FirstName = firstname;
            SureName = surename;
            TypeOfEmployee = typeOfEmployee;
            HourlyRate = hourlyRate;
            HoursWorked = hoursWorked;
            Salary = salary;
        }
        public override string ToString()
        {
            SureName = SureName.ToUpper();
            return string.Format($"{SureName}" +   $",{FirstName}, {TypeOfEmployee}");
        }
     } 

}
