using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp_ICommandDemo
{
    public class ConterViewModel : INotifyPropertyChanged
    {


        #region INotifyPropertyChanged-Member


        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            //Fire the PropertyChanged event in case somebody subscribed to it
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName)); //raise the event //raise the event
        }
        #endregion


        #region Constructors
        public ConterViewModel()
        {
            Counter = 0;
            IncrementCommand = new RelayCommand(Increment,ValidateIncrement);
        }

        #endregion
        #region Properties

        private int counter;

		public int Counter
		{
			get { return counter; }
			set { counter = value;
            OnPropertyChanged("Counter");
                    }
		}

		public void Increment(Object obj)
		{
			Counter++;
		}
        public bool ValidateIncrement(Object obj)
        {if (Counter < 10)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        private ICommand incrementCommand;

      

        public ICommand IncrementCommand
		{
			get { return incrementCommand; }
			set { incrementCommand = value;
                OnPropertyChanged(nameof(incrementCommand));
            }
		}

        #endregion


    }
}
