using System;

namespace Generics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool check = true;
            FindMax obj1 = new FindMax;

            while (check)
            {
                Console.Write("Select Option:\n" +
                    "1)Find Integer Maximum Number\n" +
                    "2)Find Float Maximum Number\n" +
                    "3)Find String Maximum\n"); 
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        int result = obj1.FindMax(4, 3, 2);
                        Console.WriteLine(result);
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine("Maximum Number is:" + result);// To display Maximum Number
                        Console.WriteLine("-----------------------------------");
                        break;
                    case 2:
                        float result2 = obj1.FindMax(4.3f, 3.2f, 2.7f);
                        Console.WriteLine(result2);
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine("Maximum Number is:" + result2);// To display Maximum Number
                        Console.WriteLine("-----------------------------------");
                        break;
                    case 3:
                        string result3 = obj1.FindMax("Raj", "Ravi", "Ram");
                        Console.WriteLine(result3);
                        Console.WriteLine("-----------------------------------");
                        Console.WriteLine("Maximum Number is:" + result3);// To display Maximum Number
                        Console.WriteLine("-----------------------------------");
                        break;
                    default:
                        check = !check;
                        break;
                }
            }
        }
    }
}