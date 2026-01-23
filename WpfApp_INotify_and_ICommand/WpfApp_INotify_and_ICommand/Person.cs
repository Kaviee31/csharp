using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WpfApp_INotify_and_ICommand
{
    //internal class Person
    //{
    //    public string FirstName { get; set; }
    //    public string Lastname { get; set; }



    //    public string FullName
    //    {
    //        get { return FirstName + " " + Lastname; }

    //    }

    //}

    #region Version 2 - Implementing INotifyPropertyChanged
    class Person : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
     

        private string firstName;


        public string FirstName
        {
            get { return firstName; }
            set { firstName = value;
                OnPropertyChanged("FullName");
            }
        }
        private string lastName;

        public string LastName
        {
            get { return lastName; }
            set { lastName = value;
                OnPropertyChanged("FullName");

            }
        }
        public string FullName
        {
            get { return FirstName + " " + LastName; }
            
        }
        private void OnPropertyChanged(string propertyName)

        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName)); //raise the event

        }



    }
    #endregion
}
