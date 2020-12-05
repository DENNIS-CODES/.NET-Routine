//MainClass.cs
// Checks if a number is a prime number
using System;
public class primenochecker

public static bool main(int num)
{
  for (int i=2; i < num; i++)
  if (num %i == 0)
  return false;
  return true;
}
public static void Main() 
{
    Console.writer("\n\nFunction : To check a number is prime or not :\n");  
    Console.WriteLine ("-----------------------\n");
    Console.Write("Input a number : ");
    int n= Convert.ToInt32(Console.ReadLine());
    if (main(n))
    console.WriteLine(n+" is a prime number");
    else
    Console.WriteLine(n+" is not a prime number");
  }
}