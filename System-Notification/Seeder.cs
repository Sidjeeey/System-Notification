using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace System_Notification
{
    public class Seeder
    {
        static Random random = new Random();

        

        public static List<Employee> GenerateRandomEmployees(int numberOfEmployees)
        {
            List<Employee> employees = new List<Employee>();

            for (int i = 1; i <= numberOfEmployees; i++)
            {
                Employee employee = new Employee
                {
                    EmpNumber = "E" + random.Next(100, 999) + "-" + random.Next(1000, 9999),
                    FirstName = RandomString(8),
                    MiddleName = RandomString(5),
                    LastName = RandomString(7),
                    CertificateNumber = RandomCertificateNumber(),
                    IssuedOn = RandomDate(),
                    ValidUntil = RandomDate()
                };

                employees.Add(employee);
            }

            return employees;
        }

        static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            char[] randomString = new char[length];
            for (int i = 0; i < length; i++)
            {
                randomString[i] = chars[random.Next(chars.Length)];
            }
            return new string(randomString);
        }

        static string RandomCertificateNumber()
        {
            return random.Next(100000, 999999).ToString(); // Change range if needed
        }

        static DateTime RandomDate()
        {
            int startYear = 2023;
            int endYear = 2028;

            // Choose a random year between 2023 and 2028
            int randomYear = random.Next(startYear, endYear + 1);

            DateTime startDate = new DateTime(randomYear, 1, 1);
            DateTime endDate = new DateTime(randomYear, 12, 31);

            int range = (endDate - startDate).Days;
            return startDate.AddDays(random.Next(range));
        }
    }
}
