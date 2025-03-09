using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_overload
{
    /*Завдання 4 

Створіть клас, який містить інформацію про дату (день, місяць, рік). 
    За допомогою механізму перевантаження операторів визначте операцію різниці двох дат (результат у вигляді кількості днів між датами), 
    а також операцію збільшення дати на певне кількість днів. 
    */
    class DateMath
    {
        private DateTime date;

        public DateMath(int day, int month, int year)
        {
            date = new DateTime(year, month, day);
        }

        public static int operator -(DateMath date1, DateMath date2)
        {
            TimeSpan difference = date1.date - date2.date;
            return (int)difference.TotalDays;
        }

        public static DateMath operator +(DateMath date, int days)
        {
            DateTime newDate = date.date.AddDays(days);
            return new DateMath(newDate.Day, newDate.Month, newDate.Year);
        }

        public override string ToString()
        {
            return date.ToString("dd.MM.yyyy");
        }
    }
}
