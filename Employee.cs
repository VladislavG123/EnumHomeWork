using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListHomeWork
{
    public class Employee
    {
        public string FullName { get; set; }
        public int Salary { get; set; }
        public DateTime InviteDate { get; set; }
        public Vacancy Vacancy { get; set; }

        public string GetAllInfo()
        {
            return $"{FullName}, {Vacancy.ToString()}, {Salary.ToString()}, {InviteDate.ToString()}";
        }
    }
}
