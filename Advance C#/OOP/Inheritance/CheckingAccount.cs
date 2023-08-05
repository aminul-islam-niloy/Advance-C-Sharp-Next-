using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_C_.OOP.Inheritance
{
    public class CheckingAccount:BankAccount
    {
        public double ServiceCharge { get; set; }


        //public string AccountNo { get; set; }
        //public string CustomerName { get; set; }
        //public double Balance { get; private set; }


        public CheckingAccount(string accountNO, string customerName, double serviceCharge):base(accountNO,customerName)
        
        { 

            ServiceCharge = serviceCharge;

        }

        public override string Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                return base.Withdraw(amount);
            }
            return "Insufficient balance";
        }

        public override void Transfer(string from, string to, double amount)
        {
           
        }
    }
}
