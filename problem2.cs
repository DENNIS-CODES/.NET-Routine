//Write a program using a loop that prints the following output.1 2 2 3 3 3 4 4 4 4 5 5 5 5 5 6 6 6 6 6 6 . . . nth iteration.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 

namespace Problem2
{

class Problem2
{

static void Main(string[] args)
{

int value;

Console.WriteLine("Enter A Value:");
value = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\n");
for (int i = 1; i <= value; i++)
{
  for (int j = 1; j <= i; j++)
  {
    Console.Write(i);
    }

Console.Write(" ");
}
Console.ReadKey();
}
}

}