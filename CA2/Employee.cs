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
        


        //public string FullTime { get; set; }
      
        public Employee(string firstname,string surename, string typeOfEmployee)
        {
            FirstName = firstname;
            SureName = surename;
            TypeOfEmployee = typeOfEmployee;
          
        }
        public override string ToString()
        {
            SureName = SureName.ToUpper();
            return string.Format($"{SureName}" +   $",{FirstName}, {TypeOfEmployee}");
        }
     } 

}
