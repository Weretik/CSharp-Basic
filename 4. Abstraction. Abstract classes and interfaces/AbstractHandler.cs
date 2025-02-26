using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    abstract class AbstractHandler
    {
        public abstract void Open();
        public abstract void Create();
        public abstract void Change();
        public abstract void Save();
    }
    class XMLHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("XML документ було змінено");
        }

        public override void Create()
        {
            Console.WriteLine("XML документ було створено");
        }

        public override void Open()
        {
            Console.WriteLine("XML документ було відкрито");
        }

        public override void Save()
        {
            Console.WriteLine("XML документ було збережено");
        }
    }
    class TXTHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("TXT документ було змінено");
        }

        public override void Create()
        {
            Console.WriteLine("TXT документ було створено");
        }

        public override void Open()
        {
            Console.WriteLine("TXT документ було відкрито");
        }

        public override void Save()
        {
            Console.WriteLine("TXT документ було збережено");
        }
    }
    class DOCHandler : AbstractHandler
    {
        public override void Change()
        {
            Console.WriteLine("DOC документ було змінено");
        }

        public override void Create()
        {
            Console.WriteLine("DOC документ було створено");
        }

        public override void Open()
        {
            Console.WriteLine("DOC документ було відкрито");
        }

        public override void Save()
        {
            Console.WriteLine("DOC документ було збережено");
        }
    }
}

/*
 * Створити клас AbstractHandler. У тілі класу створити методи void Open(), void Create(), void Change(), void Save(). 
Створити похідні класи XMLHandler, TXTHandler, DOCHandler від базового класу AbstractHandler. Написати програму, 
яка виконуватиме визначення документа і для кожного формату мають бути методи відкриття, створення, редагування, 
збереження певного формату документа.
*/