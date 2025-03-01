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

            /*
             * Завдання 3 

               Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
            Розширте приклад уроку 005_Book, створивши в класі Book вкладений клас Notes, 
            який дозволить зберігати нотатки читача.
            */

            Book darkBook = new Book();
            Book.Notes notes = new Book.Notes();

            Console.WriteLine("Введіть вашу нотатку");
            string notesText = Console.ReadLine();
            notes.AddNotes(notesText);
            
            Console.WriteLine("Остання нотатка: ");
            notes.ShowNotes();




            /*
             * Завдання 4 
            икористовуючи Visual Studio, створіть проект за шаблоном Console Application. 
            Потрібно: 
            створити розширюючий метод для цілого масиву, який сортує елементи масиву за зростанням. 
            */
            Console.WriteLine();
            int[] arr = { 11, 5, 6, 0, 9, 4, 3 };
            arr.Sort();
            Console.WriteLine("Масив за зростанням:");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }

        }
    }
}
