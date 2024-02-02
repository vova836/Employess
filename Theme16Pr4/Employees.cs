using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theme16Pr4
{
    /// <summary>
    /// Нестатический класс, описывающий сотрудников
    /// </summary>
    class Employees
    {
        /// <summary>
        /// Поле табельного номера
        /// </summary>
        int employeeNumber;
        /// <summary>
        /// Поле фамилии 
        /// </summary>
        string surname;
        /// <summary>
        /// Поле имени
        /// </summary>
        string name;
        /// <summary>
        /// Поле отчества
        /// </summary>
        string patronymic;
        /// <summary>
        /// Поле даты рождения
        /// </summary>
        DateTime dateBirth;
        /// <summary>
        /// Поле должностии
        /// </summary>
        string position;
        /// <summary>
        /// Поле оклада
        /// </summary>
        int salary;

        /// <summary>
        /// Свойства полей
        /// </summary>
        public int EmployeeNumber { get => employeeNumber; set => employeeNumber = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Name { get => name; set => name = value; }
        public string Patronymic { get => patronymic; set => patronymic = value; }
        public DateTime DateBirth { get => dateBirth; set => dateBirth = value; }
        public string Position { get => position; set => position = value; }
        public int Salary { get => salary; set => salary = value; }
        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Employees() { }
        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="employeeNumber"></param>
        /// <param name="surname"></param>
        /// <param name="name"></param>
        /// <param name="patronymic"></param>
        /// <param name="dateBirth"></param>
        /// <param name="position"></param>
        /// <param name="salary"></param>
        public Employees(int employeeNumber, string surname, string name, string patronymic, DateTime dateBirth, string position, int salary)
        {
            this.EmployeeNumber = employeeNumber;
            this.Surname = surname;
            this.Name = name;
            this.Patronymic = patronymic;
            this.DateBirth = dateBirth;
            this.position = position;
            this.salary = salary;
        }
        /// <summary>
        /// Метод вывода информации о сотруднике
        /// </summary>
        public void Output()
        {
            if (Surname == "" || Name == "" || Patronymic == "" || Position == "")
            {
                Console.WriteLine("Отсутствует информация о сотруднике\n");
            }
            else
            {
                int age = DateTime.Now.Year - DateBirth.Year;
                if (DateTime.Now.Month < dateBirth.Month) { age--; }
                Console.WriteLine($"Табельный номер - {employeeNumber}\nФамилия - {surname}\nИмя - {name}\nОтчество - {patronymic}\nДата рождения - {dateBirth:d}\nВозраст сотрудника: {age} лет\nДолжность - {position}\nОклад - {salary}\n");

            }
        }
    }
}
