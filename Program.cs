using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee
            {
                FullName = "Vasya",
                InviteDate = DateTime.Now,
                Salary = 50000,
                Vacancy = Vacancy.Clerck
            });
            employees.Add(new Employee
            {
                FullName = "Ivan",
                InviteDate = DateTime.Parse("20.02.2018"),
                Salary = 90000,
                Vacancy = Vacancy.Clerck
            });
            employees.Add(new Employee
            {
                FullName = "Clarck",
                InviteDate = DateTime.Parse("12.05.2017"),
                Salary = 110000,
                Vacancy = Vacancy.Clerck
            });
            employees.Add(new Employee
            {
                FullName = "Mark",
                InviteDate = DateTime.Parse("9.11.2018"),
                Salary = 160000,
                Vacancy = Vacancy.Manager
            });
            employees.Add(new Employee
            {
                FullName = "Oliver",
                InviteDate = DateTime.Parse("6.9.2017"),
                Salary = 80000,
                Vacancy = Vacancy.Manager
            });
            employees.Add(new Employee
            {
                FullName = "Galya",
                InviteDate = DateTime.Parse("1.1.2016"),
                Salary = 900000,
                Vacancy = Vacancy.Boss
            });
            
            Console.WriteLine("All Employees");
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.GetAllInfo());
                
            }
            
            int sumSalaryesOfClercks = 0;
            int amountClercks = 0;
            foreach (var employee in employees)
            {
                if (employee.Vacancy == Vacancy.Clerck)
                {
                    sumSalaryesOfClercks += employee.Salary;
                    amountClercks++;
                }
            }

            double avarageClercksSalary = sumSalaryesOfClercks / amountClercks;
            Console.WriteLine();
            Console.WriteLine("Avarage Clercks Salary:" + avarageClercksSalary);

            List<Employee> managers = new List<Employee>();
            foreach (var employee in employees)
            {
                if (employee.Vacancy == Vacancy.Manager && employee.Salary <= avarageClercksSalary)
                {
                    managers.Add(employee);
                }
            }
            
            managers.Sort();
            Console.WriteLine();
            Console.WriteLine("Managers with little salary");
            foreach (var manager in managers)
            {
                Console.WriteLine(manager.GetAllInfo());
            }

            Console.WriteLine();

            int bossId = 0;
            for (int i = 0; i < employees.Count; i++)
            {
                if (employees[i].Vacancy == Vacancy.Boss)
                {
                    bossId = i;
                    break;
                }
            }

            List<Employee> newEmployees = new List<Employee>();

            foreach (var employee in employees)
            {
                if (employee.InviteDate > employees[bossId].InviteDate)
                {
                    newEmployees.Add(employee);
                }
            }
            
            Console.WriteLine("Employees who invited after boss");
            foreach (var newEmployee in newEmployees)
            {
                Console.WriteLine(newEmployee.GetAllInfo());
            }

            Console.WriteLine("-----------------------------------------------------");

            List<Student> students = new List<Student>();

            students.Add(new Student
            {
                FullName = "Anatoly",
                AverageMark = 7,
                EducationForm = EducationForm.SemiStationary,
                Gender = Gender.Male,
                Group = "ASD23",
                Salary = 50000
            });
            students.Add(new Student
            {
                FullName = "Dinara",
                AverageMark = 11,
                EducationForm = EducationForm.Stationary,
                Gender = Gender.Female,
                Group = "SDP181",
                Salary = 500000
            });
            students.Add(new Student
            {
                FullName = "Ruslan",
                AverageMark = 11,
                EducationForm = EducationForm.Stationary,
                Gender = Gender.Male,
                Group = "SDP181",
                Salary = 500000
            });
            students.Add(new Student
            {
                FullName = "Sapar",
                AverageMark = 6,
                EducationForm = EducationForm.Stationary,
                Gender = Gender.Male,
                Group = "SDP181",
                Salary = 30000,
            });

            const int MINIMAL_SALARY = 42500;
            List<Student> studentsLowSalary = new List<Student>();
            List<Student> studentsHightSalary = new List<Student>();
            List<Student> hostel = new List<Student>();

            foreach (var student in students)
            {
                if (student.Salary < MINIMAL_SALARY)
                {
                    studentsLowSalary.Add(student);
                }
                else
                {
                    studentsHightSalary.Add(student);
                }
            }
            
            foreach (var student in studentsLowSalary)
            {
                hostel.Add(student);
            }
            foreach (var student in studentsHightSalary)
            {
                hostel.Add(student);
            }

            Console.WriteLine("Hostel:");
            foreach (var student in hostel)
            {
                Console.WriteLine(student.GetAllInfo());
            }
            Console.Read();
        }
    }
}
