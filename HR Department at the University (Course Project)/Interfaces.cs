using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HR_Department_at_the_University__Course_Project_
{
    public interface IStudent
    {
        Group Group { get; set; }
        List<Person> Parents { get; set; }
    }
    public interface ITeacher
    {
        Department Department { get; set; }
        string Position { get; set; }
    }
    public interface IParent
    {
        List<Person> Children { get; set; }
    }
}
