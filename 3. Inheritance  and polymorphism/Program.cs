using System;
using Task2;
using Task3;
using Task4;
using Task5;

Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;
/*
 * Завдання 2 

Використовуючи Visual Studio, створіть проект за шаблоном Console Application. Потрібно:
Створити клас, який представляє навчальний клас ClassRoom. Створіть клас учень Pupil. 
У тілі класу створіть методи void Study(), void Read(), void Write(), void Relax(). 
Створіть 3 похідні класу ExcelentPupil, GoodPupil, BadPupil від класу базового класу Pupil 
і перевизначте кожен із методів, залежно від успішності учня. Конструктор класу ClassRoom приймає 
аргументи типу Pupil, клас має складатися із 4 учнів. Передбачте можливість, що користувач може 
передати 2 або 3 аргументи. Виведіть інформацію про те, як усі учні екземпляра класу ClassRoom вміють вчитися, читати, писати, відпочивати. 
*/


Pupil pupil1 = new ExcelentPupil();
Pupil pupil2 = new BadPupil();
Pupil pupil3 = new GoodPupil();

ClassRoom classRoom = new ClassRoom(pupil1, pupil2, pupil3);

classRoom.ShowPupilsInfo();

/*
 * Завдання 3 

Використовуючи Visual Studio, створіть проект за шаблоном Console Application. Потрібно: Створити клас Vehicle. 
У тілі класу створіть поля: координати та параметри суден (ціна, швидкість, рік випуску). Створіть 3 похідні класи 
Plane, Саг і Ship. Для класу Plane має бути визначена висота та кількість пасажирів. Для класу Ship – кількість пасажирів
та порт приписки. Написати програму, яка виводить на екран інформацію про кожен засіб пересування. 
*/

Plane plane = new Plane(100, 200, 500000, 900, 2020, 10000, 150);
Car car = new Car(50, 75, 30000, 180, 2018);
Ship ship = new Ship(300, 400, 1000000, 60, 2015, 500, "Одеса");

plane.ShowInfo();
car.ShowInfo();
ship.ShowInfo();


/* 
 * Завдання 4 

Використовуючи Visual Studio, створіть проект за шаблоном Console Application, потрібно створити клас DocumentWorker. 
У тілі класу створіть три методи OpenDocument(), EditDocument(), SaveDocument(). У тіло кожного з методів додайте виведення
на екран відповідних рядків: "Документ відкритий", "Редагування документа у версії Про", "Збереження документа у версії Про".

Створіть похідний клас ProDocumentWorker. Перевизначте відповідні методи, при перевизначенні методів виводьте наступні рядки:
"Документ відредаговано", "Документ збережено у старому форматі, збереження в інших форматах є у версії Експерт".
Створіть похідний клас ExpertDocumentWorker від базового класу ProDocumentWorker. Перевизначте відповідний спосіб. 
При викликі даного методу необхідно виводити на екран "Документ збережений у новому форматі".
У тілі методу Main() реалізуйте можливість прийому від користувача номер ключа доступу pro і exp. Якщо користувач 
не вводить ключ, він може користуватися лише безкоштовною версією (створюється екземпляр базового класу), 
якщо користувач ввів номери ключа доступу pro і exp, то повинен створити екземпляр відповідної версії класу, 
наведений до базового - DocumentWorker.
*/

Console.WriteLine("\nВведіть ключ доступу (pro / exp):");
string key = Console.ReadLine();

DocumentWorker worker;


if (key == "pro")
{
    worker = new ProDocumentWorker();
    Console.WriteLine("Активована версія PRO.");
}
else if (key == "exp")
{
    worker = new ExpertDocumentWorker();
    Console.WriteLine("Активована версія EXPERT.");
}
else
{
    worker = new DocumentWorker();
    Console.WriteLine("Використовується безкоштовна версія.");
}

worker.OpenDocument();
worker.EditDocument();
worker.SaveDocument();

/*
 * Завдання 5

Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
Потрібно: Створити клас Printer. У тілі класу створіть метод void Print(string value), 
що виводить на екран значення аргументу. Реалізуйте можливість того, щоб у разі успадкування від даного класу інших класів, 
та виклику відповідного методу їх екземпляра, рядки, передані як аргументи методів, виводилися різними кольорами. 
Обов'язково використовуйте типи.
*/
Console.WriteLine();
Printer[] printers = {
            new Printer(),       
            new RedPrinter(),    
            new GreenPrinter(),
            new BluePrinter() 
        };

// Викликаємо метод Print() для кожного об'єкта
foreach (var printer in printers)
{
    printer.Print("Це текст, виведений у класі " + printer.GetType().Name);
}
