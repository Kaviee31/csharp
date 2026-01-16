using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankLibrary
{
    public class CurrentAccount : Bank    {
        #region Constructrors
        public CurrentAccount(string name, double limit): base(name) {
        overDraft=limit;
                }


        #endregion

        #region Propperties
        
        private double overDraft;

        public double OverDraft
        {
            get { return overDraft; }
            set { overDraft = value; }
        }

        #endregion

        public override void WithDraw(double cash)
        {
            if (cash <= overDraft+Balance)
            {
                Balance -= (cash);
               
                
                
            }
            else
            {
                throw new BalanceException(" over draft limit used up!!");
            }
        }
        public override string ToString() {
            return base.ToString() + "OverDraft" + overDraft;
                }

    }
}
