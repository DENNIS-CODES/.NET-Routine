//a program using a for loop that prints the following series.1 2 4 8 16 21 64 128 …nth iteration.


using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

 

namespace Problem1

{

classProblem1

    {

staticvoid Main(string[] args)

        {

Console.WriteLine("\t\tName: Ehtesham Mehmood\n\t\tRoll No: 11014119-131\n\t\tSection: AE\n \t\t        UOG\n");

int value;

double result;

Console.WriteLine("Enter Some Value:");

            value = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nSeries Is:\n");

for (int i = 0; i <= value; i++)

            {

                result = Math.Pow(2, i);

Console.Write(result);

Console.Write(" ");

            }

Console.ReadKey();

        }

    }

}