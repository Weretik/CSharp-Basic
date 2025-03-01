using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._Static_and_nested_classes
{
    class Book
    {
        public class Notes
        {
            private string Note { get; set; }

            public void AddNotes(string note)
            {
                Note = note;
            }
            public void ShowNotes()
            {
                Console.WriteLine(Note);
            }
        }
        public void FindNext(string str)
        {
            Console.WriteLine("Пошук рядка : " + str);
        }
    }

    static class FindAndReplaceManager
    {
        public static void FindNext(string str)
        {
            Console.WriteLine("Пошук рядка : " + str);
        }
    }
}
