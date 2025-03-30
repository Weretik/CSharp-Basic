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

        /// Заповнює тестовими даними
        public void SeedTestData()
        {
            Name = "НТУ \"ХПІ\"";

            //  ФАКУЛЬТЕТИ 
            var fit = new Faculty { Name = "ФІТ" };
            var fem = new Faculty { Name = "ФЕМ" };

            //  КАФЕДРИ 
            var kafProg = new Department { Name = "Кафедра програмування", Faculty = fit, IsProfile = true };
            var kafMath = new Department { Name = "Кафедра вищої математики", Faculty = fit, IsProfile = false };
            var kafEconom = new Department { Name = "Кафедра економіки", Faculty = fem, IsProfile = true };
            var kafEmpty = new Department { Name = "Кафедра без завідувача", Faculty = fem, IsProfile = false };

            // ГРУПИ
            var group1 = new Group { Name = "ІТ-101", ProfileDepartment = kafProg };
            var group2 = new Group { Name = "ІТ-102", ProfileDepartment = kafMath }; // без старости
            var group3 = new Group { Name = "ЕК-201", ProfileDepartment = kafEconom };

            kafProg.Groups.Add(group1);
            kafMath.Groups.Add(group2);
            kafEconom.Groups.Add(group3);

            // ЛЮДИ
            var student1 = new PersonFull("Анна", "Іваненко", "Петрівна", "Ж", "AA111111", "Київ", isStudent: true);
            var student2 = new PersonFull("Олег", "Ковальчук", "Сергійович", "Ч", "AA222222", "Київ", isStudent: true);
            var student3 = new PersonFull("Ірина", "Мельник", "Олегівна", "Ж", "AA333333", "Харків", isStudent: true);
            var student4 = new PersonFull("Марина", "Гончар", "Вікторівна", "Ж", "AA444444", "Львів", isStudent: true);

            var teacher1 = new PersonFull("Олександр", "Пономаренко", "Іванович", "Ч", "BB111111", "Київ", isTeacher: true);
            var teacher2 = new PersonFull("Наталія", "Семенова", "Андріївна", "Ж", "BB222222", "Одеса", isTeacher: true);
            var teacher3 = new PersonFull("Юрій", "Бойко", "Петрович", "Ч", "BB333333", "Київ", isTeacher: true);

            var combo = new PersonFull("Інна", "Шевченко", "Валеріївна", "Ж", "CC111111", "Київ", isStudent: true, isTeacher: true);

            var parent1 = new PersonFull("Іван", "Ковальчук", "Миколайович", "Ч", "PP111111", "Київ", isParent: true);
            var parent2 = new PersonFull("Світлана", "Ковальчук", "Анатоліївна", "Ж", "PP222222", "Київ", isParent: true);

            var personWithoutRole = new PersonFull("Тест", "Безролевий", "Людина", "Ч", "ZZ000000", "Херсон");

            // РОЛІ
            teacher1.Department = kafProg;
            teacher2.Department = kafMath;
            teacher3.Department = kafEconom;
            combo.Department = kafProg;

            //  ЗАВІДУВАЧ 
            kafProg.HeadOfDepartment = teacher1;
            kafEconom.HeadOfDepartment = teacher3;

            // СТУДЕНТИ У ГРУПАХ 
            student1.Group = group1;
            student2.Group = group1;
            student3.Group = group2;
            student4.Group = group3;
            combo.Group = group1;

            // СТАРОСТА 
            group1.HeadStudent = student1;

            // ДІТИ + БАТЬКИ
            student2.AddParent(parent1);
            student3.AddParent(parent1); 
            student3.AddParent(parent2);
            student4.AddParent(parent2);

            // ДОДАЄМО ДО УНІВЕРСИТЕТУ
            fit.Departments.AddRange(new[] { kafProg, kafMath });
            fem.Departments.AddRange(new[] { kafEconom, kafEmpty });

            Faculties.AddRange(new[] { fit, fem });
            group1.Students.AddRange(new[] { student1, student2, combo });
            group2.Students.Add(student3);
            group3.Students.Add(student4);

            kafProg.Teachers.AddRange(new[] { teacher1, combo });
            kafMath.Teachers.Add(teacher2);
            kafEconom.Teachers.Add(teacher3);
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
