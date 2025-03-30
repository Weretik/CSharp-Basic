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

        
    }
    public class Department
    {
        public string Name { get; set; } = string.Empty;
        public Faculty Faculty { get; set; } = new();
        public bool IsProfile { get; set; } = false;
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
