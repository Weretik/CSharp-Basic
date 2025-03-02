using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._Enumeration
{
    class Accountant
    {
        public bool AskForBonus(Post worker, int hours)
        {
            if((int)worker < hours)
            {
                Console.WriteLine("Надавати співробітнику премію");
                return true;
            }
            Console.WriteLine("Без премыъ");
            return false;
        }
    }

    enum Post
    {
        Manager = 180,
        Worker = 190,
        Director = 160,
        Accountant = 170
    }
}
