/*
 * Завдання 2 

Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 

Потрібно: Створити клас із ім'ям Rectangle. У тілі класу створити два поля, що описують довжини сторін double side1, side2. 
Створити власний конструктор Rectangle(double side1, double side2), у тілі якого поля side1 і side2 ініціалізуються значеннями аргументів. 
Створити два методи, що обчислюють площу прямокутника - double AreaCalculator() та периметр прямокутника - double PerimeterCalculator(). 
Створити дві властивості double Area та double Perimeter з одним методом доступу get. Написати програму, яка приймає від користувача 
довжини двох сторін прямокутника і виводить на екран периметр та площу. 
 
*/
Console.WriteLine("\nЗавдання 2");

Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.InputEncoding = System.Text.Encoding.Unicode;

Console.WriteLine("Введіть довжину першої сторони прямокутника: ");
double side1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введіть довжину другої сторони прямокутника: ");
double side2 = Convert.ToDouble(Console.ReadLine());

Rectangle rectangle = new Rectangle(side1, side2);

Console.WriteLine($"Площа прямокутника: {rectangle.Area}");
Console.WriteLine($"Периметр прямокутника: {rectangle.Perimeter}");


/*
 * Завдання 3 

Використовуючи Visual Studio, створіть проект за шаблоном Console Application. Потрібно: Створити клас Book. 
Створити класи Title, Author та Content, кожен з яких повинен містити одне рядкове поле та метод void Show().
Реалізуйте можливість додавання до книги назви книги, імені автора та змісту. Виведіть на екран різними кольорами 
за допомогою методу Show() назву книги, ім'я автора та зміст.
 */
Console.WriteLine("\nЗавдання 3 ");

Title title = new Title { Name = "Dark Souls" };
Author author = new Author { Name = "Жульєн Блондель" };
Content content = new Content { Text = "Спокута. Том 1. Утрачена людяність" };

// Створення об'єкта книги та виведення її деталей
Book book = new Book(title, author, content);
book.ShowBookDetails();

/*
 * Завдання 4 

Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
Потрібно: Створити класи Point та Figure. Клас Point повинен містити два цілих поля і одне рядкове поле. 
Створити три властивості одним методом доступу get. Створити власний конструктор, у тілі якого проініціалізуйте 
поля значеннями аргументів. Клас Figure повинен містити конструктори, які приймають від 3 до 5 аргументів типу Point. 
Створити два методи: double LengthSide(Point A, Point B), що розраховує довжину сторони багатокутника; void PerimeterCalculator(),
що розраховує периметр багатокутника. Написати програму, яка виводить на екран назву та периметр багатокутника.
*/
Console.WriteLine("\nЗавдання 4 ");

Point pointA = new Point(0, 0, "A");
Point pointB = new Point(3, 0, "B");
Point pointC = new Point(3, 4, "C");
Point pointD = new Point(0, 4, "D");


Figure figure = new Figure(pointA, pointB, pointC, pointD);

figure.DisplayFigureName();
figure.PerimeterCalculator();

/*
 * Завдання 6

Використовуючи Visual Studio, створіть проект за шаблоном Console Application. Потрібно:
Створити клас із ім'ям Address. У тілі класу потрібно створити поля: index, country, city, street, house, apartment. 
Для кожного поля створити властивість з двома методами доступу. Створити екземпляр класу Address. 
У поля екземпляра записати інформацію про поштову адресу. Виведіть на екран значення полів, що описують адресу.

*/

Console.WriteLine("\nЗавдання 6 ");

Address address = new Address();

address.Index = "01360";
address.Country = "Україна";
address.City = "Харкі";
address.Street = "Сумська";
address.House = "16";
address.Apartment = "8";


Console.WriteLine("Поштова адреса:");
Console.WriteLine($"Індекс: {address.Index}");
Console.WriteLine($"Країна: {address.Country}");
Console.WriteLine($"Місто: {address.City}");
Console.WriteLine($"Вулиця: {address.Street}");
Console.WriteLine($"Будинок: {address.House}");
Console.WriteLine($"Квартира: {address.Apartment}");

















//Завдання 6
class Address
{

    private string index;
    private string country;
    private string city;
    private string street;
    private string house;
    private string apartment;

    public string Index
    {
        get { return index; }
        set { index = value; }
    }


    public string Country
    {
        get { return country; }
        set { country = value; }
    }

    public string City
    {
        get { return city; }
        set { city = value; }
    }

    public string Street
    {
        get { return street; }
        set { street = value; }
    }

    public string House
    {
        get { return house; }
        set { house = value; }
    }

    public string Apartment
    {
        get { return apartment; }
        set { apartment = value; }
    }
}











//Завдання 4

class Point
{

    public int X { get; set; }
    public int Y { get; set; }
    public string Name { get; set; }

    public Point(int x, int y, string name)
    {
        X = x;
        Y = y;
        Name = name;
    }
}

class Figure
{

    private Point[] points;
    public Figure(params Point[] pointsArray)
    {
        points = pointsArray;
    }


    public double LengthSide(Point A, Point B)
    {
        return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
    }

    public void PerimeterCalculator()
    {
        double perimeter = 0;
        for (int i = 0; i < points.Length; i++)
        {
            Point currentPoint = points[i];
            Point nextPoint;
            if (i == points.Length - 1)
            {
                nextPoint = points[0];
            }
            else
            {
                nextPoint = points[i + 1];
            }
            perimeter += LengthSide(currentPoint, nextPoint);
        }

        Console.WriteLine($"Периметр багатокутника: {perimeter}");
    }

    public void DisplayFigureName()
    {
        Console.Write("Назва багатокутника: ");
        switch (points.Length)
        {
            case 3:
                Console.WriteLine("Трикутник");
                break;
            case 4:
                Console.WriteLine("Чотирикутник");
                break;
            default:
                Console.WriteLine($"{points.Length}-ти кутник");
                break;
        }
    }
}




//Завдання 3 
class Title
{
    public string Name { get; set; }

    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"Назва книги: {Name}");
        Console.ResetColor();
    }
}

class Author
{
    public string Name { get; set; }

    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Автор: {Name}");
        Console.ResetColor();
    }
}

class Content
{
    public string Text { get; set; }

    public void Show()
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"Зміст: {Text}");
        Console.ResetColor();
    }
}
class Book
{
    public Title Title { get; set; }
    public Author Author { get; set; }
    public Content Content { get; set; }


    public Book(Title title, Author author, Content content)
    {
        Title = title;
        Author = author;
        Content = content;
    }
    public void ShowBookDetails()
    {
        Title.Show();
        Author.Show();
        Content.Show();
    }
}










//  Завдання 2 

class Rectangle
{
    public double side1;
    public double side2;

    private double area;
    public double Area
    {
        get
        {
            return AreaCalculator();
        }
    }
    private double perimeter;
    public double Perimeter
    {
        get
        {
            return PerimeterCalculator();
        }
    }



    public Rectangle(double side1, double side2)
    {
        this.side1 = side1;
        this.side2 = side2;
    }

    public double AreaCalculator()
    {
        return side1 * side2;

    }
    public double PerimeterCalculator()
    {
        return (side1 + side2) * 2;

    }
}