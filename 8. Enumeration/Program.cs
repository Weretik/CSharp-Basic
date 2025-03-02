using System.IO;

namespace _8._Enumeration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            /*
             * Завдання 2 

            Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
            Створіть статичний клас із методом void Print (string stroka, int color), який виводить на екран рядок заданим кольором.
            Використовуючи перелік, створіть набір кольорів, доступних користувачеві. Введення рядка та вибір кольору надайте користувачеві. 
            */

            Console.WriteLine("Введіть рядок для виведення:");
            string userString = Console.ReadLine();

            Console.WriteLine("Оберіть колір (1 - Red, 2 - Green, 3 - Blue, 4 - Yellow, 5 - White, 6 - Cyan):");
            int userColorChoice = int.Parse(Console.ReadLine());

            Printer.Print(userString, userColorChoice);


            /*
            * Завдання 3

            Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
            Створіть перелік, який містить посади співробітників як імена констант. Надайте кожній константі значення, 
            що задає кількість годин, які повинен відпрацювати співробітник протягом місяця. 
            Створіть клас Accountant з методом bool AskForBonus (Post worker, int hours), що відображатиме давати співробітнику премію. 
            Якщо співробітник відпрацював більше годин на місяць, то йому належить премія.
            */
            Console.WriteLine();
            Accountant accountant = new Accountant();

            Console.WriteLine("Введіть посаду співробітника (Manager, Worker, Director, Accountant):");
            Post worker = (Post)Enum.Parse(typeof(Post), Console.ReadLine());

            Console.WriteLine("Введіть кількість відпрацьованих годин:");
            int hours = int.Parse(Console.ReadLine());

            accountant.AskForBonus(worker, hours);
        }
    }
}
