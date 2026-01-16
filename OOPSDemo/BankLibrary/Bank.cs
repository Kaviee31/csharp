using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    public abstract class Bank
    {
        #region Property
        private string accountName;

		public string AccountName
		{
			get { return accountName; }
			set { accountName = value; }
		}
		private double balance;

		public double Balance
		{
			get { return balance; }
			private protected set { balance = value; }
		}

		private string accountNumber;

		public string AccountNumber
		{
			get { return accountNumber; }
			set { accountNumber = value; }
		}

		static int accountcount = 100;
		#endregion
		public void Deposit(double amt)
		{
			balance += amt;
		}

        public abstract void WithDraw(double cash);

		public Bank()
		{
			accountcount++;
			AccountNumber = accountcount.ToString();

		}
		public Bank(string name): this()
		{
			accountName = name;
			
		
		}

        public override string ToString()
        {
            return $"hi {AccountName}  your account balance is {Balance} and account number is {AccountNumber}";
        }
		


    }
}


