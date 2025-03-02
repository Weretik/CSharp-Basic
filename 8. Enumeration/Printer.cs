using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._Enumeration
{
    static class Printer
    {
        public static void Print(string stroka, int color)
        {
            ConsoleColorOption selectColor = (ConsoleColorOption)color;
            Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), selectColor.ToString());
            Console.WriteLine(stroka);
            Console.ResetColor();
        }
    }

    public enum ConsoleColorOption
    {
        Red = 1,
        Green = 2,
        Blue = 3,
        Yellow = 4,
        White = 5,
        Cyan = 6
    }
    
}
