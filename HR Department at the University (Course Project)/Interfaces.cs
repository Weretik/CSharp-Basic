using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HR_Department_at_the_University__Course_Project_
{
    internal interface IStudent
    {
        Group Group { get; set; }
        List<IParent> Parents { get; set; }
    }
    internal interface ITeacher
    {
        Department ProfileDepartment { get; set; }
        string Position { get; set; }
    }
}
