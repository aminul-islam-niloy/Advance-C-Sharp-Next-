using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_C_.OOP.Inheritance
{
    public  class BankAccount
    {
        public string  AccountNo { get; set; }
        public string CustomerName { get; set;}
        public double Balance { get; private set; } 



        public string Deposit(double amount)
        {
            Balance += amount;
            return "Deposited";

        }

        public virtual string Withdraw(double amount)
        {
            Balance -= amount;
            return "Withdrawn";

        }



    }
}
