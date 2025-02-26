using Abstraction;
using System;
using System.Diagnostics;

Console.InputEncoding = System.Text.Encoding.Unicode;
Console.OutputEncoding = System.Text.Encoding.Unicode;
/*
 * Завдання 2 

Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 

Потрібно: 

Створити клас AbstractHandler. У тілі класу створити методи void Open(), void Create(), void Change(), void Save(). 
Створити похідні класи XMLHandler, TXTHandler, DOCHandler від базового класу AbstractHandler. Написати програму, 
яка виконуватиме визначення документа і для кожного формату мають бути методи відкриття, створення, редагування, 
збереження певного формату документа.
*/

Console.WriteLine("Виберіть формат документа (XML / DOC / TXT)");
string? formatDocument = Console.ReadLine();

AbstractHandler documentHandler;

switch (formatDocument)
{
	case "XML":
        documentHandler = new XMLHandler();
        break;
    case "DOC":
        documentHandler = new DOCHandler();
        break;
    default:
        documentHandler = new TXTHandler();
        break;
}

documentHandler.Create();
documentHandler.Open();
documentHandler.Change();
documentHandler.Save();

/*
 * Завдання 3 

Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 

Потрібно: 

Створіть 2 інтерфейси IPlayable та IRecodable. У кожному з інтерфейсів створіть по 3 методи 
void Play() / void Pause() / void Stop() 
та void Record() / void Pause() / void Stop() відповідно. 
Створіть похідний клас Player від базових інтерфейсів IPlayable та IRecodable.
Написати програму, яка виконує програвання та запис.
*/

Console.WriteLine();

Player player = new();

player.Play();
player.Record();
Console.WriteLine();

((IRecodable)player).Pause();
((IPlayable)player).Pause();
Console.WriteLine();

((IRecodable)player).Stop();
((IPlayable)player).Stop();