using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio
{
    class ConvertByte
    {
        public void IntToByte(int integer1, int integer2 ) {
            switch (integer1)
            {
                case var x when x > 255:
                    Console.WriteLine($"Cannot convert first number '{integer1}' to byte!");
                    if (integer2 > 255)
                    {
                        Console.WriteLine($"Cannot convert second number '{integer2}' to byte!\nTry again!");                        
                    }
                    else
                    { Console.WriteLine($"Byte conversion second number: {(byte)integer2}\nTry again!"); }                    
                    break;

                case var x when x < 255:
                    Console.WriteLine($"Byte conversion first number: {(byte)integer1}");
                    if (integer2 > 255)
                    {
                        Console.WriteLine($"Cannot convert second number '{integer1}' to byte!\nTry again!");                        
                    }
                    else
                    { Console.WriteLine($"Byte conversion second number: {(byte)integer2}\nTry again!"); }                    
                    break;
                default:
                    break;
            }

        }
            
    }
}
