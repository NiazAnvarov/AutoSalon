using Microsoft.Win32;
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
    /// Логика взаимодействия для AddEditPage.xaml
    /// </summary>
    public partial class AddEditPage : Page
    {

        private Cars currentCar = new Cars();

        public bool check = false;

        public AddEditPage(Cars SelectedCar)
        {
            InitializeComponent();

            if(SelectedCar != null)
            {
                check = true;
                currentCar = SelectedCar;
                KPPType.SelectedIndex = currentCar.KPP - 1;
                ColorType.SelectedIndex = currentCar.Color - 1;
                WheelDriveType.SelectedIndex = currentCar.WheelDrive - 1;
            }

            DataContext = currentCar;
        }

        private void ChangePictureBtn_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog myOpenFileDialog = new OpenFileDialog();
            if (myOpenFileDialog.ShowDialog() == true)
            {
                currentCar.Photo = myOpenFileDialog.FileName;
                PhotoImage.Source = new BitmapImage(new Uri(myOpenFileDialog.FileName));
            }
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();
            if (string.IsNullOrWhiteSpace(currentCar.CarMake))
                errors.AppendLine("Укажите марку автомобиля");
            if (string.IsNullOrWhiteSpace(currentCar.Model))
                errors.AppendLine("Укажите модель автомобиля");
            if (currentCar.Power <= 0)
                errors.AppendLine("Укажите мощность двигателя");
            if (currentCar.Volume <= 0)
                errors.AppendLine("Укажите объем двигателя");
            if (currentCar.Cost <= 0)
                errors.AppendLine("Укажите стоимость автомобиля");

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            currentCar.KPP = KPPType.SelectedIndex + 1;
            currentCar.WheelDrive = WheelDriveType.SelectedIndex + 1;
            currentCar.Color = ColorType.SelectedIndex + 1;

            var allCars = AutoSalonEntities.GetContext().Cars.ToList();

            allCars = allCars.Where(p => p.Model == currentCar.Model && p.CarMake == currentCar.CarMake && p.Color == currentCar.Color && p.Cost == currentCar.Cost && p.KPP == currentCar.KPP && p.Power == currentCar.Power && p.Volume == currentCar.Volume && p.WheelDrive == currentCar.WheelDrive).ToList();

            if (allCars.Count == 0 || check)
            {
                if (currentCar.ID == 0)
                    AutoSalonEntities.GetContext().Cars.Add(currentCar);
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
                MessageBox.Show("Такой автомобиль уже есть в наличии");

        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            var currentCars = (sender as Button).DataContext as Cars;

            if (currentCars.Count != 0)
                MessageBox.Show("Невозможно удалить автомобиль, т.к. этот автомобиль в наличии");
            else
            {
                if (MessageBox.Show("Вы точно хотите выполнить удаление?", "Внимание!", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
                {
                    try
                    {
                        AutoSalonEntities.GetContext().Cars.Remove(currentCars);
                        AutoSalonEntities.GetContext().SaveChanges();
                        Manager.MainFrame.GoBack();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
            }
        }

    }
}
