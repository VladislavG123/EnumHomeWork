using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListHomeWork
{
    public class QueueOfHostel
    {
        private const int BASIC_MINIMAL_SALARY = 50000; 
        public int MinimalSalary
        {
            get
            {
                return MinimalSalary;
            }
            set
            {
                if (value >=0)
                {
                    MinimalSalary = value;
                }
                else
                {
                    MinimalSalary = BASIC_MINIMAL_SALARY;
                }
            }
        }
        public Queue<Student> Students { get; set; }
        public Queue<Student> QueueOfStudents
        {
            get
            {
                GenerateQueue();
                return QueueOfStudents;
            }
        }

        private void GenerateQueue()
        {
            if (MinimalSalary <= 0)
            {
                MinimalSalary = BASIC_MINIMAL_SALARY;
            }
            // Занесение в очередь льготников.
            foreach (var student in Students)
            {
                if (student.Salary < 2 * MinimalSalary)
                {
                    QueueOfStudents.Enqueue(student);
                }
            }
            foreach (var student in Students)
            {
                if (student.Salary > 2 * MinimalSalary)
                {
                    QueueOfStudents.Enqueue(student);
                }
            }
        }
        
    }
}
