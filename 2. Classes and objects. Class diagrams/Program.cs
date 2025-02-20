/*
 * Завдання 2 

Використовуючи Visual Studio, створіть проект за шаблоном Console Application. Потрібно: Створити клас Converter.
У тілі класу створити користувальницький конструктор, який приймає три речові аргументи, і ініціалізує поля, 
що відповідають курсу 3-х основних валют, по відношенню до гривні – public Converter (double usd, double eur, 
double gbt). Написати програму, яка виконуватиме конвертацію з гривні в одну із зазначених валют,
також програма повинна проводити конвертацію із зазначених валют у гривню. 
*/
using System.Security.Principal;

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



/*
 * Завдання 4 

Використовуючи Visual Studio, створіть проект за шаблоном Console Application.

Потрібно: Створити клас Invoice. У тілі класу створити три поля int account, string customer, string provider, 
які мають бути проініціалізовані один раз (при створенні екземпляра даного класу) без можливості їхньої подальшої зміни. 
У тілі класу створити два закриті поля string article, int quantity Створити метод розрахунку вартості замовлення з ПДВ та без ПДВ.
Написати програму, яка виводить на екран суму оплати замовленого товару з ПДВ чи без ПДВ.
*/

Console.WriteLine("Введіть номер рахунку:");
int account = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введіть ім'я клієнта:");
string customer = Console.ReadLine();

Console.WriteLine("Введіть ім'я постачальника:");
string provider = Console.ReadLine();

Console.WriteLine("Введіть назву товару:");
string article = Console.ReadLine();

Console.WriteLine("Введіть кількість товару:");
int quantity = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введіть ціну за одиницю товару:");
double priceUnit = Convert.ToDouble(Console.ReadLine());


Invoice invoice = new Invoice(account, customer, provider, article, quantity);
Console.WriteLine("Cума оплати замовленого товару з ПДВ");
invoice.CalculatePriceWithVAT(priceUnit);
Console.WriteLine("Cума оплати замовленого товару без ПДВ");
invoice.CalculatePriceWithoutVAT(priceUnit);







// Завдання 4
class Invoice(int account, string customer, string provider, string article, int quantity)
{
    public int Account { get; } = account;
    public string Customer { get; } = customer;
    public string Provider { get; } = provider;

    private string article = article;
    private int quantity = quantity;


    public double CalculatePriceWithoutVAT(double priceUnit)
    {
        return priceUnit * quantity;
    }

    public double CalculatePriceWithVAT(double priceUnit)
    {
        double vatPercent = 0.22;
        double priceWithoutVAT = CalculatePriceWithoutVAT(priceUnit);
        double vat = priceWithoutVAT * vatPercent; 
        return priceWithoutVAT + vat;
    }



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