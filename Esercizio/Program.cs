using Esercizio;
using System;
using static Esercizio.ConvertByte;
namespace CastingTypeExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nEnter a first number to convert to byte: ");
            var first = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter a second number to convert to byte: ");
            var second = Convert.ToInt32(Console.ReadLine());            
            switch (first)
            {
                case var x when x > 255:
                    Console.WriteLine($"Cannot convert first number '{first}' to byte!");
                    if (second > 255)
                    { Console.WriteLine($"Cannot convert second number '{second}' to byte!\nTry again!");
                    Main(args); }
                    else
                    { Console.WriteLine($"Byte conversion second number: {(byte)second}\nTry again!"); }
                    Main(args);  
                    break;

                case var x when x < 255:
                    Console.WriteLine($"Byte conversion first number: {(byte)first}");
                    if (second > 255)
                    { Console.WriteLine($"Cannot convert second number '{second}' to byte!\nTry again!");
                    Main(args); }
                    else
                    { Console.WriteLine($"Byte conversion second number: {(byte)second}\nTry again!"); }
                    Main(args);                    
                    break;
                default:                    
                    break;
            }              
         }
    }
}
