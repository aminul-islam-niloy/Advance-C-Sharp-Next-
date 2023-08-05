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

        public override string Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                return base.Withdraw(amount);
            }
            return "Insufficient balance";
        }
    }
}
