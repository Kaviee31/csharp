using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMDemoApp.Models;

namespace MVVMDemoApp.ViewModels
{
    internal class UserViewModel : INotifyPropertyChanged


    {

        private Users userobj = new Users();
        

        public int UserId
        {
            get { return UserId; }
            set {
                if (userobj.UserId != value) {
                    UserId = value;
                }
                     }
        }

        public string FName
        {
            get { return userobj.FName; }
            set
            {
                if (userobj.FName != value)
                {
                    userobj.FName = value;
                }
            }
        }
        public string Lname
        {
            get { return userobj.LName; }
            set
            {
                if (userobj.LName != value)
                {
                    userobj.LName = value;
                }
            }
        }
        public string Country
        {
            get { return userobj.Country; }
            set
            {
                if (userobj.Country != value)
                {
                    userobj.Country = value;
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private ObservableCollection<Users> users;
        public ObservableCollection<Users> Users
        {
            get { return users; }
            set
            { 
                users = value;
                
            }
        }   

        public UserViewModel()
        {
                       Users = new ObservableCollection<Users>
            {
                new Users { UserId = 1, FName = "John", LName = "Doe", Country = "USA" },
                new Users { UserId = 2, FName = "Jane", LName = "Smith", Country = "UK" },
                new Users { UserId = 3, FName = "Sam", LName = "Brown", Country = "Canada" },
                new Users { UserId = 4, FName = "Lisa", LName = "White", Country = "Australia" }
            };

        }

    }
}
