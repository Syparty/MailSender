using System.Windows;
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
            EmailSendServiceClass email = new EmailSendServiceClass();
            email.Send(SMTPE.Text,PortE.Text,UserE.Text,PassE.Password,AddressE.Text,themE.Text,MailE.Text);
        }
    }
}
