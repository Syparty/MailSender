using System;
using System.Windows;
using System.Net;
using System.Net.Mail;

namespace MailSenderTestWPF
{
    class EmailSendServiceClass
    {
        /// <summary>
        /// Класс отправки эллектронного письма
        /// </summary>
        /// <param name="host">Требуется указать SMTP сервер</param>
        /// <param name="port">Требуется указать порт сервера</param>
        /// <param name="user_name">Требуется указать почтовый ящик</param>
        /// <param name="Password">Требуется указать пароль от почтового ящика</param>
        /// <param name="adres">Требуется указать почту адресата</param>
        /// <param name="sub">Требуется указать тему письма</param>
        /// <param name="msg">Требуется указать содержимое письма</param>
        public void Send(string host, string port, string user_name, string Password, string adres, string sub, string msg)
        {
            using (var client = new SmtpClient(host, Convert.ToInt32(port)))
            {
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(user_name, Password);
                using (var message = new MailMessage())
                {
                    message.From = new MailAddress(user_name);
                    message.To.Add(new MailAddress(adres));
                    message.Subject = sub + " " + DateTime.Now;
                    message.Body = msg;

                    try
                    {
                        client.Send(message);
                        MessageBox.Show("Отправлено", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);

                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    }

                }

            }
        }
    }
}

    
        
