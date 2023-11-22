using Microsoft.VisualBasic;
using System.Reflection;
using MethodOverloading;
namespace MethodOverloading
{ 

     class Program
    {
        //Create a method named Add, that accepts two integers and returns the sum of 
        //those two integers
        
        public static int Add(int x, int y)
        {
            return  x + y;

        }
        public static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }
        public static string Add(int x, int y, bool withDollars)
        {

            if (withDollars == true && (x + y) > 1)
            {
                return $"{x + y} dollars";
            }
            else if (withDollars == true && (x + y) == 1)
            {
                return $"{x + y} dollar";
            }
            else
            {
                return $"{x + y}";
            }
        }
        public static void Main(string[] args)
        {
            var x = 93;
            var y = 96;

            var answer = Add(x, y);

            var decimalx = 61.56m;
            var decimaly = 87.12m;

            var decimalAnswer = Add(decimalx, decimaly);

            var stringAnswer = Add(2, 2, true);

            Console.WriteLine($"Sum of add: {answer}");

            Console.WriteLine($"Sum of decimal add: {decimalAnswer}");

            Console.WriteLine($"The string answer: {stringAnswer}");
            
        }








    }
    
        
}

