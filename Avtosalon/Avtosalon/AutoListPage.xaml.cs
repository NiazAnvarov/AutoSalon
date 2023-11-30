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
    /// Логика взаимодействия для AutoListPage.xaml
    /// </summary>
    public partial class AutoListPage : Page
    {

        int CountRecords;
        int CountPage;
        int CurrentPage = 0;

        List<Cars> CurrentPageList = new List<Cars>();
        List<Cars> TableList;

        public AutoListPage()
        {
            InitializeComponent();
            List<Cars> currentCars = AutoSalonEntities.GetContext().Cars.ToList();
            CarsListView.ItemsSource = currentCars;

            SortCombo.SelectedIndex = 0;
            ComboFilter.SelectedIndex = 0;

            UpdateCars();
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditPage(null));
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new AddEditPage((sender as Button).DataContext as Cars));
        }

        private void UpdateCars()
        {
            var currentCars = AutoSalonEntities.GetContext().Cars.ToList();

            CarsListView.ItemsSource = currentCars;
            TableList = currentCars;

            if (SortCombo.SelectedIndex == 1)
            {
                currentCars = currentCars.OrderBy(p => p.Cost).ToList();
            }

            if (SortCombo.SelectedIndex == 1)
            {
                currentCars = currentCars.OrderByDescending(p => p.Cost).ToList();
            }

            currentCars = currentCars.Where(p => p.CarMake.ToLower().Contains(TBoxSearch.Text.ToLower()) || p.Model.ToLower().Contains(TBoxSearch.Text.ToLower())).ToList();

            if (ComboFilter.SelectedIndex == 1)
            {
                currentCars = currentCars.Where(p => p.Cost <= 500000).ToList();
            }

            if (ComboFilter.SelectedIndex == 2)
            {
                currentCars = currentCars.Where(p => p.Cost > 500000 && p.Cost <= 1000000).ToList();
            }

            if (ComboFilter.SelectedIndex == 3)
            {
                currentCars = currentCars.Where(p => p.Cost > 1000000).ToList();
            }

            CarsListView.ItemsSource = currentCars;
            TableList = currentCars;

            ChangePage(0, 0);
        }

        private void ChangePage(int direction, int? selectedPage)
        {
            CurrentPageList.Clear();
            CountRecords = TableList.Count;

            if (CountRecords % 10 > 0)
            {
                CountPage = CountRecords / 10 + 1;
            }
            else
            {
                CountPage = CountRecords / 10;
            }

            Boolean Ifupdate = true;

            int min;

            if (selectedPage.HasValue)
            {
                if (selectedPage >= 0 && selectedPage <= CountPage)
                {
                    CurrentPage = (int)selectedPage;
                    min = CurrentPage * 10 + 10 < CountRecords ? CurrentPage * 10 + 10 : CountRecords;
                    for (int i = CurrentPage * 10; i < min; i++)
                    {
                        CurrentPageList.Add(TableList[i]);
                    }
                }
            }
            else
            {
                switch (direction)
                {
                    case 1:
                        if (CurrentPage > 0)
                        {
                            CurrentPage--;
                            min = CurrentPage * 10 + 10 < CountRecords ? CurrentPage * 10 + 10 : CountRecords;
                            for (int i = CurrentPage * 10; i < min; i++)
                            {
                                CurrentPageList.Add(TableList[i]);
                            }
                        }
                        else
                        {
                            Ifupdate = false;
                        }
                        break;
                    case 2:
                        if (CurrentPage < CountPage - 1)
                        {
                            CurrentPage++;
                            min = CurrentPage * 10 + 10 < CountRecords ? CurrentPage * 10 + 10 : CountRecords;
                            for (int i = CurrentPage * 10; i < min; i++)
                            {
                                CurrentPageList.Add(TableList[i]);
                            }
                        }
                        else
                        {
                            Ifupdate = false;
                        }
                        break;
                }

            }
            if (Ifupdate)
            {
                PageListBox.Items.Clear();

                for (int i = 1; i <= CountPage; i++)
                {
                    PageListBox.Items.Add(i);
                }
                PageListBox.SelectedIndex = CurrentPage;

                min = CurrentPage * 10 + 10 < CountRecords ? CurrentPage * 10 + 10 : CountRecords;
                TBCount.Text = min.ToString();
                TBAllRecords.Text = " из " + CountRecords.ToString();

                CarsListView.ItemsSource = CurrentPageList;

                CarsListView.Items.Refresh();

            }

        }

        private void LeftDirButton_Click(object sender, RoutedEventArgs e)
        {
            ChangePage(1, null);
        }

        private void RightDirButton_Click(object sender, RoutedEventArgs e)
        {
            ChangePage(2, null);
        }

        private void PageListBox_MouseUp(object sender, MouseButtonEventArgs e)
        {
            ChangePage(0, Convert.ToInt32(PageListBox.SelectedItem.ToString()) - 1);
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            UpdateCars();
        }

        private void TBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateCars();
        }

        private void ComboFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateCars();
        }

        private void SortCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            UpdateCars();
        }

        private void SaleButton_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new SalePage((sender as Button).DataContext as Cars));
        }
    }

}
