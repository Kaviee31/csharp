using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonLibrary
{
    public class Person
    {
        #region Prpoerties
        private string firstName;

		public string FirstName
		{
			get { return firstName; }
			set { firstName = value; }
		}
		private string lastName;

		public string LastName
		{
			get { return lastName; }
			set { lastName = value; }
		}
		private DateTime birthDate;

		public DateTime BirthDate
		{
			get { return birthDate; }
			set { if (value ==null || value> DateTime.Today)
				{
					throw new ArgumentException(nameof(value),"invalid age");
					birthDate = DateTime.Today;
				}
				else
				{
					birthDate = value;
				}
				 }
		}
        #endregion

        #region Methods
		public string GetFullName()
		{
			return firstName + lastName;
		}

		public int GetAge()
		{
			DateTime today = DateTime.Today;
			int age = today.Year - birthDate.Year;
			if (birthDate.Date > today.AddYears(-age)){
				age--;
			}
			return age;

		}

		public string IsTodayBirthday()
		{
			bool isBirth = (DateTime.Today.Month == birthDate.Month) && (DateTime.Today.Day == birthDate.Day);
		return (isBirth)? "Happy birthday" : "not your birthday";
		}

		#endregion
		#region Constructors
		public Person()
		{

		}

		public Person (string fname, string lname, DateTime bday)
		{
			FirstName = fname;	
			LastName = lname;	
			BirthDate = bday;	
		}

		#endregion



	}
}
