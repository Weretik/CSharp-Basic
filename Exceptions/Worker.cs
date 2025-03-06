using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    /*
             * Завдання 2

                Потрібно описати структуру з ім'ям Worker, що містить такі поля:
                • прізвище та ініціали працівника;
                • назва займаної посади;
                • рік надходження працювати.

                Написати програму, яка виконує такі дії:
                • введення з клавіатури даних до масиву, що складається з п'яти елементів типу Worker (записи мають бути впорядковані за абеткою);
                • якщо значення року введено не у відповідному форматі видає виняток;
                • виведення на екран прізвища працівника, стаж роботи якого перевищує введене значення.
            */
    class Worker
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public int Year { get; set; }
        public Worker(string firstName, string lastName, string position, int year)
        {
            FirstName = firstName;
            LastName = lastName;
            Position = position;
            Year = year;
        }
        public int GetExperience()
        {
            return DateTime.Now.Year - Year;
        }
    }
}

