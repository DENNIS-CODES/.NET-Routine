//a program using conditional operators to determine whether a year entered through the keyboard is a leap year or not.
using System;
using System.collection.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
  class LeapYear
  {
    static void Main(string[]args) {
      Console.WriteLine("\t\tName: Ehtesham Mehmood\n\t\tRoll No: 11014119-131\n\t\tSection: AE\n \t\t        UOG\n");
      int year;
      string a;
      Console.WriteLine("Enter A Year:");
      year = Convert.ToInt32(Console.ReadLine());
      a= year % 4 == 0? "Year is Leap":"it is Not A LEAP Year";
      Console.WriteLine(a);
      Console.ReadKey(); 
    }
  }
}