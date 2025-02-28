using System.Text;

namespace _6._Static_and_nested_classes

{

    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            /*
             * Завдання 2 
             * Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
             * Потрібно: Створити статичний клас FindAndReplaceManager з методом void FindNext(string str) для пошуку за книгою з прикладу уроку 005_Book. 
             * При виклику цього методу проводиться послідовний пошук рядка в книзі.
             */

            FindAndReplaceManager.FindNext("Відразу після пробудження героїня потрапляє під загрозу");
        }
    }
}
