using System;
using System.Collections.Generic;
namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            IFizzBuzzService fizzBuzzService = new FizzBuzzService();
            List<string> i =new List<string>();
            i.AddRange(fizzBuzzService.GetFizzBuzz());
            i.AddRange(fizzBuzzService.GetJazzFuzz());
            foreach (var result in i)
            {
                Console.WriteLine(result);
            }
            Console.ReadLine();
        }
    }
}
