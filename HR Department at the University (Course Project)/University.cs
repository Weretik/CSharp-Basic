using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Department_at_the_University__Course_Project_
{
    public class University
    {
        public string Name { get; set; } = string.Empty;
        public List<Faculty> Faculties { get; set; } = new();
        public override string ToString() => $"Університет: {Name}";

        /// Пункт 1: Повертає список усіх студентів з можливістю сортування
        public void ShowAllStudents(string sortBy, bool isParents = true)
        {
            var students = Faculties
                .SelectMany(f => f.Departments)
                .SelectMany(d => d.Groups)
                .SelectMany(g => g.Students)
                .Where(s => s.IsStudent && isParents ? s.Parents.Count >= 0 : s.Parents.Count == 0)
                .ToList();

            students = sortBy.ToLower() switch
            {
                "піб" => students.OrderBy(s => s.FullName).ToList(),
                "група" => students.OrderBy(s => s.Group.Name).ToList(),
                "кафедра" => students.OrderBy(s => s.Group.ProfileDepartment.Name).ToList(),
                "факультет" => students.OrderBy(s => s.Group.ProfileDepartment.Faculty.Name).ToList(),
                _ => students.OrderBy(s => s.FullName).ToList()
            };

            Console.WriteLine($"\nСписок студентів (сортовано за: {sortBy}):");
            foreach (var s in students)
            {
                Console.WriteLine($"{s.FullName}, Група: {s.Group.Name}, Кафедра: {s.Group.ProfileDepartment.Name}, Факультет: {s.Group.ProfileDepartment.Faculty.Name}");
            }
        }

        /// Пункт 2: Повертає список усіх студентів без батьків з можливістю сортування
        public void ShowAllStudentsWithoutParents(string sortBy)
        {
            ShowAllStudents(sortBy, false);
        }

        /// Пункт 3: Повертає список усіх викладачів з можливістю сортування
        public void ShowAllTeachers(string sortBy)
        {
            var teachers = Faculties
                .SelectMany(f => f.Departments)
                .SelectMany(d => d.Teachers)
                .Where(t => t.IsTeacher)
                .ToList();
            teachers = sortBy.ToLower() switch
            {
                "піб" => teachers.OrderBy(t => t.FullName).ToList(),
                "кафедра" => teachers.OrderBy(t => t.Department.Name).ToList(),
                "факультет" => teachers.OrderBy(t => t.Department.Faculty.Name).ToList(),
                _ => teachers.OrderBy(t => t.FullName).ToList()
            };
            Console.WriteLine($"\nСписок викладачів (сортовано за: {sortBy}):");
            foreach (var t in teachers)
            {
                Console.WriteLine($"{t.FullName}, Кафедра: {t.Department.Name}, Факультет: {t.Department.Faculty.Name}");
            }
        }

        /// Пункт 4: Повертає список усіх завідувачів кафедр 
        public void ShowAllHeadsOfDepartments()
        {
            var heads = Faculties
                .SelectMany(f => f.Departments)
                .Where(d => d.HeadOfDepartment != null)
                .ToList();
            Console.WriteLine("\nСписок завідувачів кафедр:");
            foreach (var h in heads)
            {
                Console.WriteLine($"{h.HeadOfDepartment?.FullName}, Кафедра: {h.Name}, Факультет: {h.Faculty.Name}");
            }
        }

        /// Пункт 5: Повертає список усіх груп без старост і кафедр без завідувачів.
        public void ShowAllGroupsAndDepartmentsWithoutHeadsAndHeadStudents()
        {
            var groups = Faculties
                .SelectMany(f => f.Departments)
                .SelectMany(d => d.Groups)
                .Where(g => g.HeadStudent == null)
                .ToList();

            Console.WriteLine("\nСписок груп без старост:");
            foreach (var g in groups)
            {
                Console.WriteLine($"{g.Name}, Кафедра: {g.ProfileDepartment.Name}, Факультет: {g.ProfileDepartment.Faculty.Name}");
            }

            var departments = Faculties
                .SelectMany(f => f.Departments)
                .Where(d => d.HeadOfDepartment == null)
                .ToList();
            Console.WriteLine("\nСписок кафедр без завідувачів:");
            foreach (var d in departments)
            {
                Console.WriteLine($"{d.Name}, Факультет: {d.Faculty.Name}");
            }
        }

        /// 7. Повертає cписок усіх викладачів, які мають дітей-студентів.
        public void ShowAllTeachersWithChildrenStudents()
        {
            var teachers = Faculties
                .SelectMany(f => f.Departments)
                .SelectMany(d => d.Teachers)
                .Where(t => t.Children.OfType<PersonFull>().Any(c => c.IsStudent))
                .ToList();
            Console.WriteLine("\nСписок викладачів, які мають дітей-студентів:");
            foreach (var t in teachers)
            {
                Console.WriteLine($"{t.FullName}, Кафедра: {t.Department.Name}, Факультет: {t.Department.Faculty.Name}");
            }
        }

        /// 6. Повертає список у заданого батька всіх його дітей-студентів.
        public void ShowAllChildrenStudentsOfParent(PersonFull parent)
        {
            
            var students = parent.Children
                .OfType<PersonFull>()
                .Where(c => c.IsStudent)
                .ToList();

            if (!students.Any())
            {
                Console.WriteLine("Немає дітей-студентів.");
                return;
            }

            Console.WriteLine($"\nСписок дітей-студентів батька {parent.FullName}:");
            foreach (var s in students)
            {
                Console.WriteLine($"{s.FullName}");
            }
        }
    }
    public class Department
    {
        public string Name { get; set; } = string.Empty;
        public Faculty Faculty { get; set; } = new();
        public bool IsProfile { get; set; } = false;
        public List<Group> Groups { get; set; } = new();
        public PersonFull? HeadOfDepartment { get; set; }
        public List<PersonFull> Teachers { get; set; } = new();

        public override string ToString() => $"Кафедра: {Name} ({(IsProfile ? "профільна" : "непрофільна")})";
    }
    public class Faculty
    {
        public string Name { get; set; } = string.Empty;
        public List<Department> Departments { get; set; } = new();

        public override string ToString() => $"Факультет: {Name}";
    }
    public class Group
    {
        public string Name { get; set; } = string.Empty;
        public Department ProfileDepartment { get; set; } = new();
        public PersonFull? HeadStudent { get; set; }
        public List<PersonFull> Students { get; set; } = new();

        public override string ToString() => $"Група: {Name}";
    }
}
