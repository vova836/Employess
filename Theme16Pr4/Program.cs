using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme16Pr4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите кол-во сотрудников: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Employees[] empl = new Employees[n];
            for (int i = 0; i< n; i++)
            {
                Console.Write("Введите табельный номер сотрудника: ");
                int employeeNumber = int.Parse(Console.ReadLine());
                Console.Write("Введите фамилию сотрудника: ");
                string surname = Console.ReadLine();
                Console.Write("Введите имя сотрудника: ");
                string name = Console.ReadLine();
                Console.Write("Введите отчество сотрудника: ");
                string patronymic = Console.ReadLine();
                Console.Write("Введите дату рождения сотрудника: ");
                DateTime dateBirth = DateTime.Parse(Console.ReadLine());
                Console.Write("Введите должность сотрудника: ");
                string position = Console.ReadLine();
                Console.Write("Введите оклад сотрудника: ");
                int salary = int.Parse(Console.ReadLine());
                empl[i] = new Employees(employeeNumber, surname, name, patronymic, dateBirth, position, salary);
                Console.WriteLine();
            }
            Console.WriteLine("Сотрудники: \n");
            foreach (var emplo in empl)
            {
                Employees empl1 = new Employees(emplo.EmployeeNumber, emplo.Surname, emplo.Name, emplo.Patronymic, emplo.DateBirth, emplo.Position, emplo.Salary);
                empl1.Output();

            }    
            //Console.WriteLine("Сотрудники: \n");
            //foreach (var employee in empl)
            //{
            //    if (employee.EmployeeNumber == null || employee.Surname == "" || employee.Name == "" || employee.Patronymic == "" || employee.DateBirth == null || employee.Position == "" || employee.Salary == null)
            //    {
            //        Console.WriteLine("Отсутствует информация о сотруднике\n");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Табельный номер - {employee.EmployeeNumber}\nФамилия - {employee.Surname}\nИмя - {employee.Name}\nОтчество - {employee.Patronymic}\nДата рождения - {employee.DateBirth}\nДолжность - {employee.Position}\nОклад - {employee.Salary}\n");
            //        int age = DateTime.Now.Year - employee.DateBirth.Year;
            //        if (employee.DateBirth.Month<DateTime.Now.Month) { age--; }
            //        Console.Write($"Возраст сотрудника: {age} лет");
            //    }

            //}
            

            Console.ReadKey();
        }
    }
}
