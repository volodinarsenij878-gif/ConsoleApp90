using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program46
{
    internal class Program
    {
        static void Main()
        {
            byte b = 1;
            b += 2; // компилятор неявно делает: b = (byte)(b + 2)
            Console.WriteLine($"b после b += 2: {b}"); // Вывод: 3
        }
    }
}
