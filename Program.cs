using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Emp
    {
        public string FullName(string fname, string lname)
        {
            return fname + " " + lname;        
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //String firstName;
            //firstName = Console.ReadLine();
            //Console.WriteLine("Welcome " + firstName);
            //Console.ReadKey();


            //int id;
            //string employeeName;
            //char employeeGender;
            //int employeeSalary;
            //DateTime doj;

            //Console.WriteLine("Enter ID");
            //id = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Employee Name");
            //employeeName = Console.ReadLine();
            //Console.WriteLine(" Enter Employee Gender");
            //employeeGender = char.Parse(Console.ReadLine());
            //Console.WriteLine("Enter employee salary");
            //employeeSalary = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter date of birth");
            //doj = DateTime.Parse(Console.ReadLine());

            //Console.WriteLine("Welcome {0} \n ID : {0} \tEmployee Name : {1} \tEmployee gender: {2} \tEmployee salary : {3} \tDOJ : {4} " ,id,employeeName,employeeGender,employeeSalary,doj);

            //if (employeeSalary > 90000)
            //{
            //    Console.WriteLine("You have to pay 30% tax");
            //}
            //else
            //{
            //    Console.WriteLine("You have to pay 15% tax");
            //}

            //Console.ReadKey();

            Emp emp = new Emp();
            Console.WriteLine(emp.FullName("sam" , "dicosta"));
            Console.WriteLine(emp.FullName(lname: "dicosta" , fname: "sam"));
            Console.WriteLine(emp.FullName("sam", "dicosta"));
            Console.ReadKey();





        }
    }
}
