using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    public abstract class Person
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Patronymic { get; set; }
        public string? Gender { get; set; }
        public string? PassportData { get; set; }
        public string? Address { get; set; }

        public string FullName => $"{LastName} {FirstName} {Patronymic}";

        protected Person(string firstName, string lastName, string patronymic, string gender, string passportData, string address)
        {
            FirstName = firstName;
            LastName = lastName;
            Patronymic = patronymic;
            Gender = gender;
            PassportData = passportData;
            Address = address;
        }

    }

    public class PersonFull : Person, IStudent, ITeacher, IParent
    {
        public bool IsStudent { get; }
        public bool IsTeacher { get; }
        public bool IsParent { get; }
        public PersonFull(
            string firstName, 
            string lastName, 
            string patronymic, 
            string gender, 
            string passportData, 
            string address,
            bool isStudent = false,
            bool isTeacher = false,
            bool isParent = false
            ): base(firstName, lastName, patronymic, gender, passportData, address)
        {
            IsStudent = isStudent;
            IsTeacher = isTeacher;
            IsParent = isParent;
        }

       
        public List<Person> Parents { get; set; } = new();
        public List<Person> Children { get; set; } = new();
        public Group Group { get; set; } = new();
        public Department Department { get; set; } = new Department();
        public string Position { get; set; } = string.Empty;
        

        public void AddParent(PersonFull parent, bool IsAddChild = true)
        {
            if (!Parents.Contains(parent))
            {
                Parents.Add(parent);
                if (IsAddChild) parent.AddChild(this, false);
            }
            
        }
        public void AddChild(PersonFull child, bool IsAddParent)
        {
            if (!Children.Contains(child))
            {
                Children.Add(child);
                if (IsAddParent) child.AddParent(this, false);
            }  
        }

        public override string ToString()
        {
            var roles = new List<string>();
            if (IsStudent) roles.Add("Студент");
            if (IsTeacher) roles.Add("Викладач");
            if (IsParent) roles.Add("Батько/Мати");

            return $"{FullName} — {string.Join(", ", roles)}";
        }
    }

}
