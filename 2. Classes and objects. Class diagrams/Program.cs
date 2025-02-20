/*
 * Завдання 2 

Використовуючи Visual Studio, створіть проект за шаблоном Console Application. Потрібно: Створити клас Converter.
У тілі класу створити користувальницький конструктор, який приймає три речові аргументи, і ініціалізує поля, 
що відповідають курсу 3-х основних валют, по відношенню до гривні – public Converter (double usd, double eur, 
double gbt). Написати програму, яка виконуватиме конвертацію з гривні в одну із зазначених валют,
також програма повинна проводити конвертацію із зазначених валют у гривню. 
*/
Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.InputEncoding = System.Text.Encoding.Unicode;

Converter converter = new Converter(40, 45, 52.51); 


Console.WriteLine("Введіть суму в гривнях:");
double amountUAH = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введіть валюту для конвертації (usd, eur, gbp):");
string currency = Console.ReadLine();

double convertedAmount = converter.ConvertUahTo(currency, amountUAH);
Console.WriteLine($"{amountUAH} UAH = {convertedAmount} {currency}");


double amountBackInUAH = converter.ConvertToUah(currency, convertedAmount);
Console.WriteLine($"{convertedAmount} {currency} = {amountBackInUAH} UAH");


/*
 * Завдання 3 

Використовуючи Visual Studio, створіть проект за шаблоном Console Application. Потрібно створити клас Employee. 
У тілі класу створити користувальницький конструктор, який приймає два рядкові аргументи, та ініціалізує поля, 
що відповідають прізвищу та імені співробітника. Створити метод, що розраховує оклад співробітника (залежно від посади та стажу) 
та податковий збір. Написати програму, яка виводить на екран інформацію про співробітника (прізвище, ім'я, посада), оклад та податковий збір. 
*/
Console.WriteLine();
Console.WriteLine("Введіть ім'я співробітника:");
string firstName = Console.ReadLine();

Console.WriteLine("Введіть прізвище співробітника:");
string lastName = Console.ReadLine();

Console.WriteLine("Введіть посаду співробітника (manager, accountant, supervisor):");
string position = Console.ReadLine();

Console.WriteLine("Введіть кількість років стажу:");
int yearsExperience = Convert.ToInt32(Console.ReadLine());

Employee employee = new Employee(firstName, lastName, position, yearsExperience);
employee.DisplayInfo();


















// Завдання 3
class Employee(string firstName, string lastName, string position, int yearsExperience)
{
    public string? FirstName { get; set; } = firstName;
    public string? LastName { get; set; } = lastName;
    public string? Position { get; set; } = position;
    public int YearsExperience { get; set; } = yearsExperience;


    public Employee(string firstName, string lastName) : this(firstName, lastName, "manager", 0)
    {
    }
    public double CalculateSalary()
    {
        double baseSalary = 20_000; 
        double experienceBonus = YearsExperience * 500;

        double salary = Position switch
        {
            "manager" => baseSalary + experienceBonus + 1000,
            "accountant" => baseSalary + experienceBonus + 3000,
            "supervisor" => baseSalary + experienceBonus + 5000,
            _ => baseSalary + experienceBonus
        };

        return salary;
    }
    public double CalculateTax(double salary)
    {
        return salary * 0.22; 
    }
    public void DisplayInfo()
    {
        double salary = CalculateSalary();
        double tax = CalculateTax(salary);

        Console.WriteLine("Інформація про співробітника:");
        Console.WriteLine($"Ім'я: {FirstName}");
        Console.WriteLine($"Прізвище: {LastName}");
        Console.WriteLine($"Посада: {Position}");
        Console.WriteLine($"Оклад: {salary} грн");
        Console.WriteLine($"Податковий збір (22%): {tax} грн");
    }

}


// Завдання 2 
class Converter
{
    public double UsdRate { get; set; }
    public double EurRate { get; set; }
    public double GbtRate { get; set; }
    public Converter(double usd, double eur, double gbt)
    {
        UsdRate = usd;
        EurRate = eur;
        GbtRate = gbt;
    }

    public double ConvertToUah(string currency, double amount) => currency switch
    {
        "usd" => UsdRate * amount,
        "eur" => EurRate * amount,
        "gbt" => GbtRate * amount,
        _ => 0

    };
    public double ConvertUahTo(string currency, double amount) => currency switch
    {
        "usd" => amount / UsdRate,
        "eur" => amount / EurRate,
        "gbt" => amount / GbtRate,
        _ => 0

    };

}