using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._3.reference.and.significant.types.data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            _ = GetCurrentDepartment("Банк", "Санкт-Петербург");

            Console.ReadKey();
        }

        class Company
        {
            public string Type;
            public string Name;
        }

        class Department
        {
            public Company Company;
            public City City;
        }

        class City
        {
            public string Name;
        }

        static Department GetCurrentDepartment(string CompanyType,string CityName)
        {
            Department department = new Department
            {
                City = new City(),
                Company = new Company()
            };
              
            department.City.Name = CityName;
            department.Company.Type = CompanyType;

            if (department?.Company?.Type == "Банк" && department?.City?.Name == "Санкт-Петербург")
            {
                Console.WriteLine("У банка {0} есть отделение в Санкт-Петербурге", department?.Company?.Name ?? "Неизвестная компания,");
            }
            return department;
        }

    //Напишите такой код, который бы при типе компании, равному типу "Банк", и городе "Санкт-Петербург" 
    //выводил в консоль сообщение "У банка ??? есть отделение в Санкт-Петербурге", где вместо "???" выводилось бы название компании.
    //Если у компании нет названия, вместо него должно быть "Неизвестная компания".



    }
}
