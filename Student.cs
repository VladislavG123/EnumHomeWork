using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListHomeWork
{
    public class Student
    {
        public string FullName { get; set; }
        public string Group { get; set; }
        public int AverageMark { get; set; }
        public int Salary { get; set; }
        public Gender Gender { get; set; }
        public EducationForm EducationForm { get; set; }

        public string GetAllInfo()
        {
            return $"{FullName},group {Group},avg mark: {AverageMark}, Salary: {Salary}, {Gender.ToString()}, {EducationForm.ToString()}";
        }

        
        
    }
}
