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

            /*
             * Завдання 3

            Створіть клас House з двома полями та властивостями. 
            Створіть два методи Clone() та DeepClone(), які виконують поверхневе та глибоке копіювання відповідно.
            Реалізуйте найпростіший спосіб перевірки.
            */
            Console.WriteLine();
            House house1 = new House(100, "вул. Лесі Українки, 1");
            House house2 = house1.Clone();
            House house3 = house1.DeepClone();

            Console.WriteLine($"Дім 1:{house1}");
            Console.WriteLine($"Дім 2:{house2}");
            Console.WriteLine($"Дім 3:{house3}");
            
            house2.Area = 200;
            house2.Address = "вул. Шевченка, 2";

            house3.Area = 300;
            house3.Address = "вул. Велика кільцева, 3";

            Console.WriteLine();
            Console.WriteLine("Після змін площи та адреси");

            Console.WriteLine($"Дім 1:{house1}");
            Console.WriteLine($"Дім 2:{house2}");
            Console.WriteLine($"Дім 3:{house3}");
        }
    }
}
