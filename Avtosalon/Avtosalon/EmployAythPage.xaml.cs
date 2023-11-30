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

namespace Avtosalon
{
    /// <summary>
    /// Логика взаимодействия для EmployAythPage.xaml
    /// </summary>
    public partial class EmployAythPage : Page
    {
        public EmployAythPage()
        {
            InitializeComponent(); 
        }

        private void EmplAuthButton_Click(object sender, RoutedEventArgs e)
        {

            var allEmpl = AutoSalonEntities.GetContext().Employees.ToList();

            var user = allEmpl.Where(p => p.Login == EmployAuthLoginBox.Text && p.Password == EmployAuthPaswBox.Text).ToList();

            if(user.Count != 0)
            {
                user = user.Where(p => p.RoleID == 1).ToList();
                if(user.Count != 0)
                {
                    MessageBox.Show("Успешный вход в систему");
                    Manager.MainFrame.Navigate(new AutoListPage());
                }
                else
                {
                    MessageBox.Show("Успешный вход в систему");
                    Manager.MainFrame.Navigate(new ManagerAutoListPage());
                }
                
            }
            else
            {
                MessageBox.Show("Не правильный логин или пароль!");
            }

        }
    }
}
