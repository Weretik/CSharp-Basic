using System.Text;

namespace Operator_overload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            /*
             * Завдання 2

            Створіть клас Block із 4 полями сторін, перевизначте в ньому методи: 
            Equals - здатний порівнювати блоки між собою, 
            ToString - повертає інформацію про поля блоку.
            */
            Block block1 = new Block(1, 2, 3, 4);
            Block block2 = new Block(1, 2, 3, 4);
            if (block1.Equals(block2))
            {
                Console.WriteLine("Блоки однакові");
                Console.WriteLine(block1);
            }
            else
            {
                Console.WriteLine("Блоки не однакові");
                Console.WriteLine(block1);
                Console.WriteLine(block2);
            }


        }
    }
}
