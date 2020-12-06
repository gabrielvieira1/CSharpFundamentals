using System;
using CSharpFundamentals.Math;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var gabriel = new Person();
            gabriel.FirstName = "Gabriel";
            gabriel.LastName = "Vieira";
            gabriel.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);
        }
    }
}
