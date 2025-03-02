namespace _9._Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            /*
             * 
             * Завдання 2 

             Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
            Створіть чотири лямбда оператора для виконання арифметичних дій: (Add – додавання, Sub – віднімання, Mul – множення, Div – поділ). 
            Кожен лямбда оператор повинен приймати два аргументи та повертати результат обчислення. Лямбда оператор поділу повинен перевірити поділ на нуль. 
            Написати програму, яка виконуватиме арифметичні дії, вказані користувачем. 
            */
            Operation add = (a, b) => { return a + b; };
            Operation sub = (a, b) => { return a - b; };
            Operation mul = (a, b) => { return a * b; };
            Operation div = (a, b) => { return b == 0 ? 0 : a / b; };

            Console.WriteLine("Виберіть операцію (Add / Sub / Mul / DIv):");
            string operation = Console.ReadLine();

            Console.WriteLine("Введіть перше число: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введіть друге число: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Результат операції:");
            switch (operation)
            {
                case "Add":
                    Console.WriteLine(add(num1, num2));
                    break;
                case "Sub":
                    Console.WriteLine(sub(num1, num2));
                    break;
                case "Mul":
                    Console.WriteLine(mul(num1, num2));
                    break;
                case "Div":
                    Console.WriteLine(div(num1, num2));
                    break;
                default:
                    Console.WriteLine("Невірна операція");
                    break;
            }

            /*
             * Завдання 3 

            Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
            Створіть анонімний метод, який приймає як аргумент масив делегатів і повертає середнє арифметичне значення значень методів, 
            повідомлених з делегатами в масиві. Методи, повідомлені з делегатами з масиву, повертають випадкове значення типу int. 
            */
            Console.WriteLine();

            RandomNumberDelegate[] delegates = new RandomNumberDelegate[]
            {
                new RandomNumberDelegate(GenerateRandomNumber),
                new RandomNumberDelegate(GenerateRandomNumber),
                new RandomNumberDelegate(GenerateRandomNumber),
                new RandomNumberDelegate(GenerateRandomNumber)
            };

            AverageDelegate averageMethod = delegate (RandomNumberDelegate[] delArray)
            {
                double sum = 0;
                foreach (var del in delArray)
                {
                    sum += del();
                }
                return sum / delArray.Length; 
            };

            double average = averageMethod(delegates);

            // Выводим результат
            Console.WriteLine("Среднее арифметическое значение: " + average);





        }
    

        //Завдання 2 
        delegate double Operation(double a, double b);

        //Завдання 3
        delegate double AverageDelegate(RandomNumberDelegate[] delArray);
        delegate int RandomNumberDelegate();

        public static int GenerateRandomNumber()
        {
            Random rnd = new Random();
            return rnd.Next(1, 100);
        }
    }
}

