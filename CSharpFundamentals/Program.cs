using System;
using CSharpFundamentals.Math;

namespace CSharpFundamentals
{
   /* public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }
   */

    public class Person1
    {
        public int Age;
    }

    class Program
    {
        static void Main(string[] args)
        {
            var number = 1;
            Increment(number);
            Console.WriteLine(number);

            var person1 = new Person1() {Age = 20};
            MakeOld(person1);
            Console.WriteLine(person1.Age);
            
            /* Reference types and value types
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));

            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 4;
            Console.WriteLine(string.Format("array1[0]: {0}, array2[0]: {1}", array1[0], array2[0]));

            */
            /* Enum
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);

            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);

            Console.WriteLine(methodId.ToString());

            var methodName = "Express";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine(shippingMethod);
            */

         /*  String 
            var firstName = "Gabriel";
            var lastName = "Vieira";

            var fullName = firstName + " " + lastName;

            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);

            var names = new string[3] { "Gabriel", "Ciro", "Alice" };
            var formattedNames = string.Join(",", names);

            var text = @"Hi John
            Look into the following paths
            c:\folder1\folder2
            c:\folder3\folder4";
            Console.WriteLine(text); */

            /* Variaveis 
              var gabriel = new Person();
              gabriel.FirstName = "Gabriel";
              gabriel.LastName = "Vieira";
              gabriel.Introduce();

              Calculator calculator = new Calculator();
              var result = calculator.Add(1, 2);
              Console.WriteLine(result);
            */
            /* Arrays
             var numbers = new int[3];

             Console.WriteLine(numbers[0]);
             Console.WriteLine(numbers[1]);
             Console.WriteLine(numbers[2]);

             var flags = new bool[3];
             flags[0] = true;

             Console.WriteLine(flags[0]);
             Console.WriteLine(flags[1]);
             Console.WriteLine(flags[2]);

             var names = new string[3] { "Gabriel", "Ciro", "Alice" };
             Console.WriteLine(names[0]);
             Console.WriteLine(names[1]);
             Console.WriteLine(names[2]);*/
        }

        public static void Increment(int number)
        {
            number += 10;
            Console.WriteLine(number);
        }

        public static void MakeOld(Person1 person1)
        {
            person1.Age += 10;
        }
    }
}
