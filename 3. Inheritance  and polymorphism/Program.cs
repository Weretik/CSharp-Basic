using System;
using Task2;
using Task3;
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



Plane plane = new Plane(100, 200, 500000, 900, 2020, 10000, 150);
Car car = new Car(50, 75, 30000, 180, 2018);
Ship ship = new Ship(300, 400, 1000000, 60, 2015, 500, "Одеса");

car.ShowInfo();
ship.ShowInfo();

