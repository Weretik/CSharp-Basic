using System.Runtime.InteropServices;
using System.Text;

namespace HR_Department_at_the_University__Course_Project_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            University university = new University();
            Console.WriteLine("Заповнити тестовими даними?: yes/no");
            university.SeedTestData();
            

            Console.WriteLine("\n=== Меню університету ===");
            Console.WriteLine("1. Список усіх студентів (сортування)");
            Console.WriteLine("2. Студенти без батьків (сортування)");
            Console.WriteLine("3. Список викладачів (сортування)");
            Console.WriteLine("4. Завідувачі кафедр");
            Console.WriteLine("5. Групи без старост і кафедри без завідувачів");
            Console.WriteLine("6. Пошук дітей-студентів конкретного батька");
            Console.WriteLine("7. Викладачі з дітьми-студентами");
            Console.WriteLine("0. Вихід");
            Console.Write("Оберіть опцію: ");
            var input = Console.ReadLine();
            Console.WriteLine();

            switch (input)
            {
                case "1":
                    Console.Write("Сортувати за (піб/група/кафедра/факультет): ");
                    university.ShowAllStudents(Console.ReadLine());
                    break;
                case "2":
                    Console.Write("Сортувати за (піб/група/кафедра/факультет): ");
                    university.ShowAllStudentsWithoutParents(Console.ReadLine());
                    break;
                case "3":
                    Console.Write("Сортувати за (піб/кафедра/факультет): ");
                    university.ShowAllTeachers(Console.ReadLine());
                    break;
                case "4":
                    university.ShowAllHeadsOfDepartments();
                    break;
                case "5":
                    university.ShowAllGroupsAndDepartmentsWithoutHeadsAndHeadStudents();
                    break;
                case "6":
                    Console.Write("Введіть ПІБ батька: ");
                    var name = Console.ReadLine()?.Trim().ToLower();
                    var parent = university.Faculties
                        .SelectMany(f => f.Departments)
                        .SelectMany(d => d.Groups)
                        .SelectMany(g => g.Students)
                        .Concat(university.Faculties.SelectMany(f => f.Departments).SelectMany(d => d.Teachers))
                        .OfType<PersonFull>()
                        .FirstOrDefault(p => p.IsParent && p.FullName.ToLower() == name);
                    if (parent != null)
                        university.ShowAllChildrenStudentsOfParent(parent);
                    else
                        Console.WriteLine("Батька не знайдено.");
                    break;
                case "7":
                    university.ShowAllTeachersWithChildrenStudents();
                    break;
                case "0":
                    Console.WriteLine("Завершення програми.");
                    return;
                default:
                    Console.WriteLine("Невірна опція. Спробуйте ще раз.");
                    break;
            }
        }
    }
}
