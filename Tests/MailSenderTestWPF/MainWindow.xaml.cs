using System.Windows;
using System.Net;
using System.Net.Mail;
using System.Security;
using System;

namespace MailSenderTestWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var host = "SMTP.Office365.com";
            var port = 587;
            var user_name = UserE.Text;
            var msg = "Привет !" + DateTime.Now;
            SecureString Password = PassE.SecurePassword; 
            using (var client = new SmtpClient(host, port))
            {
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(user_name, Password);
                using (var message = new MailMessage())
                {
                    message.From = new MailAddress("alextalaev@outlook.com","Алексей");
                    message.To.Add(new MailAddress("lera95-14@mail.ru", "Алексей"));
                    message.Subject = "Сообщение с приветствием" +DateTime.Now;
                    message.Body = msg;

                    try
                    {
                        client.Send(message);
                        MessageBox.Show("Отправлено", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);

                    } catch (Exception error)
                    {
                        MessageBox.Show(error.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    }

                }

            }
        }
    }
}
