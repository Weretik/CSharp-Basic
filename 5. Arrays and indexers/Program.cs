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
