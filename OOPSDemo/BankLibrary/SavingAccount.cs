using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    public class SavingAccount : Bank
    {


        public SavingAccount() { }
        public SavingAccount(string acntname, bool salAcnt) : base(acntname)
        {
            IsSalAccount = salAcnt;
        }
        private bool isSalAccount;

        public bool IsSalAccount
        {
            get { return isSalAccount; }
            set { isSalAccount = value; }
        }
        public sealed override string ToString()
        {
            return base.ToString() + " Is Salary Account : " + isSalAccount;


        }
        public override void WithDraw(double cash)
        { if (isSalAccount)
            {
                if ((Balance - cash) >= 0)
                {
                    Balance -= cash;
                }
                else
                {
                    throw new BalanceException("Insufficient Balance");

                }
            }
           
        }

    }
}
