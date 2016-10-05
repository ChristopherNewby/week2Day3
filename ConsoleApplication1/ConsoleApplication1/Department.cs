using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public  class Department : Person
    {
        #region variables
        protected string managerName, location, departmentName;

        #endregion
        public string Manager
        {
            get
            {
                return managerName;
            }

            set
            {
                managerName = value;
            }
        }

        public string DeptName
        {
            get
            {
                return departmentName;
            }

            set
            {
                departmentName = value;
            }
        }



        public string Location
        {
            get
            {
                return location;
            }

            set
            {
                location = value;
            }
        }

        
        public void changeDepartmentName(string department)
        {
           departmentName = department ;
           // return firstName + lastName;
        }

    }
}
