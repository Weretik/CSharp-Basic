using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject
{
    public class Base
    {
        public void PublicMethod()
        {
            Console.WriteLine("Це публічний метод класу Base.");
        }
    }
    namespace MyNamespace
    {
        public class MyClass
        {
            public void PublicMethod()
            {
                Console.WriteLine("Це публічний метод класу MyClass.");
            }
        }
    }
}