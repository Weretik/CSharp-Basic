using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Завдання 4
Використовуючи Visual Studio, створіть проект за шаблоном Console Application. Потрібно: Створити клас Article, що містить наступні закриті поля:
• Назва товару;
• назва магазину, в якому продається товар;
• вартість товару в гривнях. 

Створити клас Store, який містить закритий масив елементів типу Article.

Забезпечити такі можливості:
• висновок інформації про товар за номером за допомогою індексу;
• висновок на екран інформації про товар, назва якого введено з клавіатури, якщо таких товарів немає, видати відповідне повідомлення.
Написати програму, виведення на екран інформацію про товар.
*/
namespace Arrays
{
    class Article
    {
        private string productName;
        private string storeName;
        private double price;

        public Article(string product, string store, double price)
        {
            this.productName = product;
            this.storeName = store;
            this.price = price;
        }

        public void showInfo()
        {
            Console.WriteLine($"Назва товару: {productName}");
            Console.WriteLine($"назва магазину: {storeName}");
            Console.WriteLine($"вартість товару: {price}");
        }
        public string showName()
        {
            return productName;
        }
    }

    class Shop
    {
        private Article[] listArticle;
        public Article this[int index]
        {
            get
            {
                if (index >= 0 && index < listArticle.Length)
                {
                    return listArticle[index];
                } 
                else
                {
                    Console.WriteLine("Індекс товара не знайдено");
                    return null;
                }  
            }
            set
            {
                if (index >= 0 && index < listArticle.Length)
                {
                    listArticle[index] = value;
                }
            }
        }
        
        public Article this[string name]
        {
            get
            {
                foreach (var item in listArticle)
                {
                    if (name == item.showName())
                    {
                        return item;
                    }
                    
                }
                Console.WriteLine("Такого товару немає");
                return null;
            }
        }
        public Shop(params Article[] shopName)
        {
            listArticle = shopName;
        }
    }
}
