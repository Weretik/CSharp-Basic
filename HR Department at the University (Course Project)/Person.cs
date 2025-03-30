using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * и. Відомості про кожну людину мають
містити прізвище, ім'я, по батькові, стать, паспортні дані, місце проживання. Для студентів додатково має бути
інформація про батьків та групу. Для викладачів додатково має бути інформація про кафедру та посаду.
Потрібно передбачити можливу ситуацію, коли одна й та сама людина може бути одночасно студентом,
батьком і викладачем. Один з батьків може мати кілька дітей-студентів.
*/

namespace HR_Department_at_the_University__Course_Project_
{
    internal abstract class Person
    {
        public string FistName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public string Gender { get; set; }
        public string PassportData { get; set; }
        public string Address { get; set; }

        public string FullName => $"{LastName} {FistName} {Patronymic}";


    }
}
