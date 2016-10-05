using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Employee : Person
    {
        #region variables
        protected int payGrade, hours;
        protected DateTime hireDate;
        protected DateTime termDate;
        double payRate;
        Department empDepartment;
        #endregion

        #region properties


        public DateTime Hire
        {
            get
            {
                return hireDate;
            }

            set
            {
                hireDate = value;
            }
        }
        public DateTime Termination
        {
            get
            {
                return termDate;
            }

            set
            {
                termDate = value;
            }
        }
        public int PayGrade
        {
            get
            {
                return payGrade;
            }

            set
            {
                payGrade = value;
            }
        }
        public int HoursWorked
        {
            get
            {
                return hours;
            }

            set
            {
                hours = value;
            }
        }

        public double Rate
        {
            get
            {
                return payRate;
            }

            set
            {
                payRate = value;
            }
        }
        public Department EMPDepartment
        {
            get
            {
                return empDepartment;
            }

            set
            {
                empDepartment = value;
            }
        }
        #endregion

        public virtual DateTime dayHired()
        {
            return hireDate = DateTime.Now.AddYears(-1);

        }

        public virtual DateTime dayFired()
        {
            return termDate = (DateTime.Now);

        }

        public virtual void Promote()
        {
            payRate = payRate * 1.4;
            payGrade = payGrade + 1;
        }

    }
}





