using Arrays;
using System.Text;

Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

/*
 * Завдання 2
Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 

Потрібно: 
Створити масив розмірністю N елементів, заповнити його довільними цілими значеннями. 
Вивести найбільше значення масиву, найменше значення масиву, загальну суму елементів, 
середнє арифметичне всіх елементів, вивести всі непарні значення.
*/

Random random = new();

Console.WriteLine("Введіть розмірність масиву");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(0, 20);
}


Console.WriteLine($"Найбільше значення масиву: {array.Max()}");

Console.WriteLine($"Найменше значення масиву: {array.Min()}");

Console.WriteLine($"Загальну суму елементів: {array.Sum()}");

Console.WriteLine($"Середнє арифметичне всіх елементів: {array.Average()}");

Console.WriteLine("Всі непарні значення:");
foreach (var num in array)
{
    if (num % 2 != 0)
    {
        Console.WriteLine(num);
    }
}
Console.WriteLine();
/*
 * Завдання 3
Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
Потрібно: 
Створити клас MyMatrix, який забезпечує надання матриці довільного розміру з можливістю зміни числа рядків і стовпців. 
Написати програму, яка виводить на екран матрицю і похідні від неї матриці різних порядків.
*/

Console.Write("Введіть кількість рядків: ");
int rows = int.Parse(Console.ReadLine());
Console.Write("Введіть кількість стовпців: ");
int cols = int.Parse(Console.ReadLine());

MyMatrix matrix = new MyMatrix(rows, cols);
Console.WriteLine("Початкова матриця:");
matrix.PrintMatrix();

Console.Write("Введіть нову кількість рядків: ");
int newRows = int.Parse(Console.ReadLine());
Console.Write("Введіть нову кількість стовпців: ");
int newCols = int.Parse(Console.ReadLine());

matrix.Resize(newRows, newCols);
Console.WriteLine("Змінена матриця:");
matrix.PrintMatrix();
Console.WriteLine();

/*
 * Завдання 4
 * 
Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
Потрібно: 

Створити клас Article, що містить наступні закриті поля:
• Назва товару;
• назва магазину, в якому продається товар;
• вартість товару в гривнях. 

Створити клас Store, який містить закритий масив елементів типу Article.
Забезпечити такі можливості:
• висновок інформації про товар за номером за допомогою індексу;
• висновок на екран інформації про товар, назва якого введено з клавіатури, якщо таких товарів немає, видати відповідне повідомлення.
Написати програму, виведення на екран інформацію про товар.
*/

Shop shop = new Shop(
    new Article("Гарбуз", "АТБ", 235.85),
    new Article("Диня", "Рост", 155.99),
    new Article("Булочка", "Кулиничі", 35.50)
);

Console.Write("Введіть індекс необхідного товару:");
int index = int.Parse(Console.ReadLine());
Console.WriteLine("Інформація про товар:");
shop[index]?.showInfo();

Console.Write("\nВведіть назву товару:");
string productName = Console.ReadLine();
Console.WriteLine("Інформація про товар:");
shop[productName]?.showInfo();