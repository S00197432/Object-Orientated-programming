using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam
{
    public abstract class Account
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string InterestDate { get; set; }
        public float Balance { get; set; }
        public string AccountType { get; set; }

        public Account(string firstname, string lastname, string interestdate, string accounttype, float balance)
        {
            FirstName = firstname;
            LastName = lastname;
            InterestDate = interestdate;
            AccountType = accounttype;
            Balance = balance;
        }
        public override string ToString()
        {

            return string.Format($"{FirstName}" + $"{LastName}" + $"{InterestDate}" + $"{AccountType}" + $"{Balance}");
        }

    }
    
    public class SavingsAccount : Account
    {
       
    }
    public class CurrentAccount : Account
    {
       
    }
}

