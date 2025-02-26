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
