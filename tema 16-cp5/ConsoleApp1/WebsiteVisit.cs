using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class WebsiteVisit
    {

        /// <summary>
        /// адрес открытой web-странички;
        /// </summary>
        private string PageAddress;

        /// <summary>
        /// ip-адрес посетителя
        /// </summary>
        private string ipAddress;

        /// <summary>
        /// web-браузер посетителя
        /// </summary>
        private string webBrowser;

        /// <summary>
        /// дата визита
        /// </summary>
        private DateTime visitDate;

        /// <summary>
        /// время визита
        /// </summary>
        private TimeSpan visitTime;

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="pageAddress"></param>
        /// <param name="ipAddress"></param>
        /// <param name="webBrowser"></param>
        /// <param name="visitDate"></param>
        /// <param name="visitTime"></param>
        public WebsiteVisit(string pageAddress, string ipAddress, string webBrowser, DateTime visitDate, TimeSpan visitTime)
        {
            PageAddress = pageAddress;
            IpAddress = ipAddress;
            WebBrowser = webBrowser;
            VisitDate = visitDate;
            VisitTime = visitTime;
        }


        public string PageAddress1 { get { return PageAddress; } set { PageAddress = value; } }
        public string IpAddress { get { return ipAddress; } set { ipAddress = value; } }
        public string WebBrowser { get { return webBrowser; } set { webBrowser = value; } }
        public DateTime VisitDate { get { return visitDate; } set { visitDate = value; } }
        public TimeSpan VisitTime { get { return visitTime; } set { visitTime = value; } }


        /// <summary>
        /// Метод для вывода информации о посещении
        /// </summary>
        public void DisplayInfo()
        {
            Console.WriteLine($"Адрес страницы: {PageAddress}");
            Console.WriteLine($"IP-адрес посетителя: {IpAddress}");
            Console.WriteLine($"Web-браузер посетителя: {WebBrowser}");
            Console.WriteLine($"Дата визита: {VisitDate.ToShortDateString()}");
            Console.WriteLine($"Время визита: {VisitTime.ToString(@"hh\:mm\:ss")}");
        }





    }
}
