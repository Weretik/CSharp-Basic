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

        }
        delegate double Operation(double a, double b);

    }
}
