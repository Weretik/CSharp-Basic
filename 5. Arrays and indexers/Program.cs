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