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
    /// Логика взаимодействия для SalePage.xaml
    /// </summary>
    public partial class SalePage : Page
    {

        private Cars _currentCar = new Cars();

        public SalePage(Cars SelectedCar)
        {
            InitializeComponent();
            if (SelectedCar != null)
            {
                this._currentCar = SelectedCar;
            }

            DataContext = _currentCar;

            var _currentClient = AutoSalonEntities.GetContext().Clients.ToList();

            ComboClientSale.ItemsSource = _currentClient;

        }

        private Sales _currentClientAutosalon = new Sales();

        private void SaleButtonSV_Click(object sender, RoutedEventArgs e)
        {

            if (_currentCar.Count == 0)
            {
                MessageBox.Show("Автомобиля нет в наличии");
                Manager.MainFrame.GoBack();
                return;
            }

            if (ComboClientSale.SelectedItem == null)
            {
                MessageBox.Show("Выберите клиента");
                return;
            }

            _currentClientAutosalon.ClientID = ComboClientSale.SelectedIndex + 1;
            _currentClientAutosalon.CarID = _currentCar.ID;
            _currentClientAutosalon.DateOfSale = DateTime.Today;

            if (_currentClientAutosalon.ClientID == 0)
                AutoSalonEntities.GetContext().Sales.Add(_currentClientAutosalon);
            try
            {
                _currentCar.Count--;
                AutoSalonEntities.GetContext().SaveChanges();
                MessageBox.Show("Успешная продажа");
                Manager.MainFrame.GoBack();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
