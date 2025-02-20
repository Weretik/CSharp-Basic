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