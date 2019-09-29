using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MailSender.Controls;

namespace MailSender
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() => InitializeComponent();


        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void UserControl1_LeftButtonClick(object sender, EventArgs e)
        {
            if (!(sender is UserControl1 switcher)) return;
            MaintabControl.SelectedIndex--;
            if (MaintabControl.SelectedIndex == 0)
            {
                switcher.LeftButtonVisible = false;
            }
            else if (MaintabControl.SelectedIndex == 1)
            {
                switcher.RightButtonVisible = true;
            }



        }
        private void UserControl1_RightButtonClick(object sender, EventArgs e)
        {
            if (!(sender is UserControl1 switcher)) return;
            MaintabControl.SelectedIndex++;
            if (MaintabControl.SelectedIndex == 2)
            {
                switcher.RightButtonVisible = false;
            }
            else if (MaintabControl.SelectedIndex == 1)
            {
                switcher.LeftButtonVisible = true;
            }

        }

    }
}
