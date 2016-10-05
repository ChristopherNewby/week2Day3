using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Person
    {
        #region variables
        //Shortcut to create 2 variables of the same type
        protected string firstName, lastName;
        DateTime birthDate;
        public int ssNumber;


        #endregion

        public string LastName
        {
            get
            {
                return lastName;
            }

            set
            {
                lastName = value;
            }
        }



        public string FirstName
        {
            get
            {
                return firstName;
            }

            set
            {
                firstName = value;
            }
        }

        public DateTime DateOfBirth
        {
            get
            {
                return birthDate;
            }

            set
            {
                birthDate = value;
            }
        }

        public int SSNumber
        {
            get
            {
                return ssNumber;
            }

            set
            {
                ssNumber = value;
            }
        }

        public virtual void changeName(string first, string last)
        {
            firstName = first;
            lastName = last;

        }
    }

}











