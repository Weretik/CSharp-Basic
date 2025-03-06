namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;
            /*
             * Завдання 2

                Потрібно описати структуру з ім'ям Worker, що містить такі поля:
                • прізвище та ініціали працівника;
                • назва займаної посади;
                • рік надходження працювати.

                Написати програму, яка виконує такі дії:
                • введення з клавіатури даних до масиву, що складається з п'яти елементів типу Worker (записи мають бути впорядковані за абеткою);
                • якщо значення року введено не у відповідному форматі видає виняток;
                • виведення на екран прізвища працівника, стаж роботи якого перевищує введене значення.
            */
            
            Worker[] workers = new Worker[2];

            for (int i = 0; i < workers.Length; i++)
            {
                Console.WriteLine($"Працівник {i+1}");

                Console.WriteLine("Введіть імя співробітника");
                string firstName = Console.ReadLine();

                Console.WriteLine("Введіть Фамілію співробітника");
                string lastName = Console.ReadLine();

                Console.WriteLine("Введіть Посаду співробітника");
                string position = Console.ReadLine();

                Console.WriteLine("Введіть рік народження співробітника");

                int years;
                try
                {
                    years = int.Parse(Console.ReadLine());
                    if (years < 1900 || years > DateTime.Now.Year)
                    {
                        throw new Exception($"Невірний формат дати, введіть рік (від 1990 до {DateTime.Now.Year})");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    years= int.Parse(Console.ReadLine());
                }

                workers[i] = new Worker(firstName, lastName, position, years);
            }
            Array.Sort(workers, (x, y) => x.FirstName.CompareTo(y.FirstName));
            Console.WriteLine();
            Console.WriteLine("Інфорамація про співробітників:");

            foreach (Worker worker in workers)
            {
                Console.Write($"Імя: {worker.FirstName}, Стаж: {worker.GetExperience()} років");
                Console.WriteLine();
            }
            
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
            Price[] prices = new Price[2];

            for (int i = 0; i < prices.Length; i++)
            {
                Console.WriteLine("Введіть назву товара");
                string productName = Console.ReadLine();
                Console.WriteLine("Введіть назву магазину");
                string shopName = Console.ReadLine();
                Console.WriteLine("Введіть ціну за товар");
                double price = double.Parse(Console.ReadLine());

                prices[i] = new Price(productName, shopName, price);
                Console.WriteLine();
            }

            Array.Sort(prices, (x, y) => x.shopName.CompareTo(y.shopName));

            Console.Write("Який магазин Вас цікавить?: ");
            foreach (Price price in prices)
            {
                Console.Write($"{price.shopName} ");
   
            }
            Console.WriteLine();
            string shop = Console.ReadLine();

            try
            {
                if (prices[0].shopName == shop)
                {
                    prices[0].ShowInfo();
                }
                else if (prices[1].shopName == shop)
                {
                    prices[1].ShowInfo();
                }
                else
                {
                    throw new Exception("Такого магазину немає");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



            /*
             * Завдання 5

            Використовуючи Visual Studio, створіть проект за шаблоном Console Application. Створіть клас Calculator. 
            У тілі класу створіть чотири методи для арифметичних дій: Add – додавання, Sub – віднімання,
            Mul – множення, Div – розподіл. Метод поділу повинен перевірити поділ на нуль, якщо перевірка не проходить, 
            згенерувати виняток. Користувач вводить значення, над якими хоче зробити операцію та вибрати саму операцію. 
            У разі виникнення помилок повинні викидатися винятки.
            */
            Calculator calc = new Calculator();
            try
            {
                Console.WriteLine("Введіть перше число:");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Введіть друге число:");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Виберіть операцію (+, -, *, /):");
                string operation = Console.ReadLine();

                double result = 0;

                switch (operation)
                {
                    case "+":
                        result = calc.Add(num1, num2);
                        break;
                    case "-":
                        result = calc.Sub(num1, num2);
                        break;
                    case "*":
                        result = calc.Mul(num1, num2);
                        break;
                    case "/":
                        result = calc.Div(num1, num2);
                        break;
                    default:
                        Console.WriteLine("Невідома операція.");
                        break;
                }
                Console.WriteLine($"Результат: {result}");

            }
            catch (FormatException)
            {
                Console.WriteLine("Помилка: введено невірне число.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Сталася помилка: {ex.Message}");
            }




        }
    }
}
