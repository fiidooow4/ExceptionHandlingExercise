using System;
using System.Collections.Generic;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new char[] { '1', '2', '3', '4', '5', '6', 'a', 'b', 'c' };

            var numbers = new List<int>();

            var str = "";

            foreach (var item in arr)
            {
                try
                {
                    str = item.ToString();

                    var number = int.Parse(str);

                  
                    numbers.Add(number);
                }
                catch (Exception e)
                {
                    
                    Console.WriteLine($"Unable to Parse '{item}'");
                }
                finally
                {
                    
                     Console.WriteLine(numbers);
                }
            }

            
            Console.WriteLine("Numbers successfully added to the list:");
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
