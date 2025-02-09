using System;

namespace _6._3.reference.and.significant.types.data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            _ = GetCurrentDepartment("Банк", "Санкт-Петербург");

            Console.WriteLine();

            _ = GetCurrentDepartment(null, "Санкт-Петербург",null);

            Console.WriteLine();

            _ = GetCurrentDepartment("Bank", null, "Kingston");

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


        static Department GetCurrentDepartment(string CompanyType, string CityName,string CompanyName)
        {
            Department department = new Department
            {
                City = new City(),
                Company = new Company()
            };
            string str = "no data";            
            department.City.Name = CityName;
            department.Company.Type = CompanyType;
            department.Company.Name = CompanyName;

            Console.WriteLine($"Тип компании - '{department?.Company?.Type ?? str}' Название города - '{department?.City?.Name ?? str}'  Название компании - '{department?.Company?.Name ?? str}'");
            
            return department;
        }


        //Напишите такой код, который бы при типе компании, равному типу "Банк", и городе "Санкт-Петербург" 
        //выводил в консоль сообщение "У банка ??? есть отделение в Санкт-Петербурге", где вместо "???" выводилось бы название компании.
        //Если у компании нет названия, вместо него должно быть "Неизвестная компания".



    }
}
