using Collections;
using LibraryProject;
using LibraryProject.MyNamespace;

namespace Namespace._Preprocessor_directives_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Завдання 1

            Використовуючи приклад виконаного домашнього завдання 3 з 14 уроку, 
            реалізуйте можливість підключення вашого простору імен та роботи з MyDictionary аналогічно екземпляру класу Dictionary.

            */

            MyDictionary<string, int> myDict = new MyDictionary<string, int>();

            /*
             * Завдання 2

            Створіть клас із методом позначеним модифікатором доступу public. 
            Доведіть, що до цього методу можна звернутися не тільки з поточного складання, але і з похідного класу зовнішнього складання.

            */

            Derived derived = new Derived();
            derived.PublicMethod();

            /*
             * Завдання 4 

            Створіть власний простір імен MyNamespace з класом MyClass і підключіть його до іншої програми.
            */
            MyClass myClass = new MyClass();
            myClass.PublicMethod();
        }
    }
    public class Derived : Base
    {
        
    }
}
