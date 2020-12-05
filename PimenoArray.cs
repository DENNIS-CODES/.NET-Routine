//a program that takes 10 values from the user in an array and then shows the number of prime values in the array.
using System;
using System.collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace PrimenoArray {
  class PrimenoArray {
    static void Main(string[] args) {
      int[] array = newint[10];
      int count = 0;
      int i;
      int j;
      int k = 2;
      for (i = 0; i < 10; i++) {
        Console.WriterLine("Enter " + i + "Value");
        array[i] = Convert.ToInt32(Console.
        ReadLine());
      }
      for (j = 0; j < 10; j++) {
        for (k = 2; j < array[count]; k++) {
          if (array[count] % k == 0) {
            goto to;
          }
        }
        to: if (k == array[count]) {
          Console.WriterLine("Entered Number Is " + array[count] + "A Prime Number.");
        }
        if (array[count] == 0 || array[count] == 1){
          Console.WriterLine("Enter Number Is " + array[count] + "NOt A Composite Number Nor A Prime Number.");
        }
        count++;
      }
      Console.ReadKey();
    }
  }
}