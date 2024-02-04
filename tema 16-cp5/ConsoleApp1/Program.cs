using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            // Пример использования класса
            WebsiteVisit visit1 = new WebsiteVisit("example.com", "192.168.1.1", "Chrome", DateTime.Now, new TimeSpan(10, 30, 0));
            WebsiteVisit visit2 = new WebsiteVisit("example.com", "192.168.1.2", "Firefox", DateTime.Now, new TimeSpan(15, 45, 0));

            // Вывод информации о посещениях
            visit1.DisplayInfo();
            Console.WriteLine();
            visit2.DisplayInfo();

            Console.ReadKey();











        }
    }
}
