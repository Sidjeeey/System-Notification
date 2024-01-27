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
                    LastName = RandomString(10),
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
            int range = (DateTime.Today - DateTime.Parse("01/01/2000")).Days;
            return DateTime.Parse("01/01/2000").AddDays(random.Next(range));
        }
    }
}
