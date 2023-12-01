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
    /// Логика взаимодействия для ClientAddPage.xaml
    /// </summary>
    public partial class ClientAddPage : Page
    {

        private Clients client = new Clients();

        public ClientAddPage()
        {
            InitializeComponent();

        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            var currentClient = AutoSalonEntities.GetContext().Clients.ToList();
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(ClientSurname.Text))
                errors.AppendLine("Напишите фамилию клиента");
            if (string.IsNullOrWhiteSpace(ClientName.Text))
                errors.AppendLine("Напишите имя клиента");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            currentClient = currentClient.Where(p => p.Surname == ClientSurname.Text && p.Firstname == ClientName.Text && p.Patronymic == ClientPatronymic.Text).ToList();

            if(currentClient.Count == 0)
            {

                client.Surname = ClientSurname.Text;
                client.Firstname = ClientName.Text;
                client.Patronymic = ClientPatronymic.Text;

                AutoSalonEntities.GetContext().Clients.Add(client);

                try
                {
                    AutoSalonEntities.GetContext().SaveChanges();
                    MessageBox.Show("Информация сохранена");
                    Manager.MainFrame.GoBack();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            else
            {
                MessageBox.Show("Уже является клиентом автосалона");
            }
        }
    }
}
