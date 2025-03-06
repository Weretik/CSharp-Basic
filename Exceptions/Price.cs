using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    

    /*
     * Завдання 3 

        Використовуючи Visual Studio, створіть проект за шаблоном Console Application. Потрібно описати структуру з іменем Price, що містить такі поля:
        • назва товару;
        • назва магазину, де продається товар;
        • вартість товару у гривнях.
        Написати програму, яка виконує такі дії:
        • введення з клавіатури даних до масиву, що складається з двох елементів типу Price (записи мають бути впорядковані в алфавітному порядку за назвами магазинів);
        • виведення на екран інформації про товари, що продаються в магазині, назва якого введена з клавіатури (якщо такого магазину немає, вивести виняток).
    */
    struct Price
    {
        
        string productName { get; set; }
        public string shopName { get; set; }
        double price { get; set; }

        public Price(string productName, string shopName, double price)
        {

            this.productName = productName;
            this.shopName = shopName;
            this.price = price;
        }

        public void ShowInfo()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine($"В магазині {shopName} товар - {productName} коштує {price} грн");
        }
    }
}
