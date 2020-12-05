//Maximumfinder.cs
// Method Maximum With three parameters
using System;

class MaximumFinder
{
  static void Main()
  {
    // prompt for and input three floating-point values
    Console.Write ("Enter first floating-point value: ");
    double number1 = double.parse(Console.ReadLine());
    Console.Write ("Enter second floating-point value: ");
    double number2 = double.parse(Console.ReadLine());
    Console.Write ("Enter third floating-point value: ");
    double number3 = double.parse(Console.ReadLine());
    //detrmine the maximum of three values
    double result = Maximum(number1, number2, number3);
    //display maximum value
    Console.WriteLine("Maximum is: " +result); 
  }
  //returns the maximum of its three double parameters
  static double Maximum(double X, double y, double Z){
    double maximumValue = x;//assume x is the largest to start
    //determine whether y is  greater than maximumValue
if (y > maximumValue)
{
  maximumValue = y;
}
// determine weather z is greater than maximumValue
if (z > maximumValue)
{
  maximumValue = z;
}
return maximumValue;
  }
}