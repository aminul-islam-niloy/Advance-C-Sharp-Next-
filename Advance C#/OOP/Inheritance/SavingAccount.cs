
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_C_.OOP.Inheritance
{
    public class SavingAccount:BankAccount
    {

     
        public double Interestamount { get; set; }


        public SavingAccount(string accountNO, string customerName, double interestamount):base(accountNO,customerName)
        {
          
            Interestamount = interestamount;
        }
       

        public override string Withdraw(double amount)
        {
          if(Balance >= amount) 
            {
              return base.Withdraw(amount);
            }
            return "Insufficient balance";
        }
    }
}
