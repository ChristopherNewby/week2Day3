using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
   public class Program
    {
        static void Main(string[] args)
        {

            Department Sales = new Department();
            Sales.Location = ("Office");
            Sales.Manager = ("");

            Department Floor = new Department();
            Floor.Location = ("Store");
            Floor.Manager = ("");


            Employee Chris = new Employee();
            Chris.FirstName = "Chris";
            Chris.LastName = "Newby";
            Chris.SSNumber = 999999999;
            Chris.DateOfBirth = new DateTime(1989, 5, 10);
            Chris.Hire = new DateTime(2016, 10, 5);
            Chris.dayHired();
            Chris.Termination = new DateTime(1900, 09, 9);
            Chris.HoursWorked = 40;
            Chris.PayGrade = 1;
            Chris.Rate = 15.50;
            Chris.EMPDepartment = Sales;
            

            Employee David = new Employee();
            David.FirstName = "David";
            David.LastName = "Harris";
            David.SSNumber = 343434343;
            David.DateOfBirth = new DateTime(1990, 12, 06);
            David.Hire = new DateTime(2016, 10, 5);
            David.dayHired();
            David.Termination = new DateTime(1995, 09, 9);
            David.HoursWorked = 40;
            David.PayGrade = 1;
            David.Rate = 15.50;
            David.EMPDepartment = Sales;

            Employee Patty = new Employee();
            Patty.FirstName = "Patty";
            Patty.LastName = "Hill";
            Patty.SSNumber = 111111111;
            Patty.DateOfBirth = new DateTime(1986, 1, 03);
            Patty.Hire = new DateTime(2016, 10, 5);
            Patty.dayHired();
            Patty.Termination = new DateTime(1991, 09, 9);
            Patty.HoursWorked = 40;
            Patty.PayGrade = 1;
            Patty.Rate = 15.50;
            Patty.EMPDepartment = Sales;
            

            Employee Andrea = new Employee();
            Andrea.FirstName = "Andrea";
            Andrea.LastName = "Peterson";
            Andrea.SSNumber = 777777777;
            Andrea.DateOfBirth = new DateTime(1993, 6, 15);
            Andrea.Hire = new DateTime(2016, 10, 5);
            Andrea.dayHired();
            Andrea.Termination = new DateTime(1973, 09, 9);
            Andrea.HoursWorked = 40;
            Andrea.PayGrade = 1;
            Andrea.Rate = 15.50;
            Andrea.EMPDepartment = Floor;

            Employee Jacob = new Employee();
            Jacob.FirstName = "Jacob";
            Jacob.LastName = "Brady";
            Jacob.SSNumber = 656543298;
            Jacob.DateOfBirth = new DateTime(1970, 7, 19);
            Jacob.Hire = new DateTime(2016, 10, 5);
            Jacob.dayHired();
            Jacob.Termination = new DateTime(1989, 09, 9);           
            Jacob.HoursWorked = 40;
            Jacob.PayGrade = 1;
            Jacob.Rate = 15.50;
            Jacob.EMPDepartment = Floor;


            Employee [] myArray = new Employee[5];
            myArray[0] = Chris;
            myArray[1] = David;
            myArray[2] = Patty;
            myArray[3] = Andrea;
            myArray[4] = Jacob;

            utils.PayEmployee(myArray);
            Patty.Promote();
            Jacob.Promote();            
            Andrea.changeName("Jason", "King");
            utils.PayEmployee(myArray);



            Console.WriteLine();




            //Console.WriteLine(Chris.FirstName);
            //Console.WriteLine(Chris.LastName);
            //Console.WriteLine(Chris.ssNumber);
            //Console.WriteLine(Chris.DateOfBirth);
            //Console.WriteLine(Chris.Hire);
            //Console.WriteLine(Chris.HoursWorked);
            //Console.WriteLine(Chris.PayGrade);
            //Console.WriteLine(Chris.Rate);
            //Console.WriteLine(Chris.EMPDepartment);






            Console.ReadLine();


        }
    }
}
