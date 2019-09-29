using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailSenderLib.Entityes;

namespace MailSenderLib.Data
{
    public static class TestData
    {
        public static List<Server> Server { get; } = new List<Server>
        {
            new Server {ID=1,Name="Yandex", Address = "smtp.yandex.ru", UserName ="UserName", Password = "Pass" },
            new Server {ID=2,Name="Mail", Address = "smtp.mail.ru", UserName ="UserName", Password = "Pass" },
            new Server {ID=3,Name="Gmail", Address = "smtp.gmail.ru", Port= 465, UserName ="UserName", Password = "Pass" },
            new Server {ID=4,Name="Outlook", Address = "SMTP.Office365.com", Port= 587, UserName ="UserName", Password = "Pass" }
        };



        public static List<Sender> Sender { get; } = new List<Sender>
        {
            new Sender {ID = 1, Name="Иванов", Address = "ivanov@yandex.ru"},
            new Sender {ID = 2, Name="Петров", Address = "petrov@yandex.ru"},
            new Sender {ID = 3, Name="Сидоров", Address = "sidorov@yandex.ru"},
        };
    }
}
