using System;
using System.Collections.Generic;

namespace Generics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //bool check = true;
            // FindMax obj1 = new FindMax();
            // while (check)
            // {
            //     Console.Write("Select Option:\n" +
            //         "1)Find Integer Maximum Number\n" +
            //         "2)Find Float Maximum Number\n" +
            //         "3)Find String Maximum\n"); 
            //     int option = Convert.ToInt32(Console.ReadLine());
            //     switch (option)
            //     {
            //         case 1:
            //             int maxnum = obj1.MaxMethod();
            //             //int result = obj.FindMaximum(2,3,4,5);
            //             Console.WriteLine(maxnum);
            //             Console.WriteLine("-----------------------------------");
            //             Console.WriteLine("Maximum Number is:" + maxnum);// To display Maximum Number
            //             Console.WriteLine("-----------------------------------");
            //             break;
            //         case 2:
            //             float result2 = obj1.FindMaximum(4.3f, 3.2f, 2.7f);
            //             Console.WriteLine(result2);
            //             Console.WriteLine("-----------------------------------");
            //             Console.WriteLine("Maximum Number is:" + result2);// To display Maximum Number
            //             Console.WriteLine("-----------------------------------");
            //             break;
            //         case 3:
            //             string result3 = obj1.FindMaximum("Raj", "Ravi", "Ram");
            //             Console.WriteLine(result3);
            //             Console.WriteLine("-----------------------------------");
            //             Console.WriteLine("Maximum Number is:" + result3);// To display Maximum Number
            //             Console.WriteLine("-----------------------------------");
            //             break;
            //         default:
            //             check = !check;
            //             break;
            //     }
            // }
            int[] arr = { 555, 112, 344, 678, 432  };
            FindMaxAndSort obj = new FindMaxAndSort(arr);
            obj.PrintMaxvalue();

        }
    }
}