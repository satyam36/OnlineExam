using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Exmination.Models.Services
{
    public class StudentAdmitCard
    { 
            public static List<Student> GetAllStudents() =>
                new List<Student>
                {
                new Student { Name="Mike", LastName="Turner", Age=35, Gender="Male"},
                new Student { Name="Sonja", LastName="Markus", Age=22, Gender="Female"},
                new Student { Name="Luck", LastName="Martins", Age=40, Gender="Male"},
                new Student { Name="Sofia", LastName="Packner", Age=30, Gender="Female"},
                new Student { Name="John", LastName="Doe", Age=45, Gender="Male"}
                };
    }
}


