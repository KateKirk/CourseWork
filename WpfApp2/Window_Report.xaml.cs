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
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для Window_Report.xaml
    /// </summary>
    public partial class Window_Report : Window
    {
        ESIR1Entities1 context;
        public Window_Report()
        {
            InitializeComponent();
            context = new ESIR1Entities1();
            DataGridReport.ItemsSource = context.Report__of_repair.ToList();
        }
        public void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            var newReport = new Report__of_repair();
            context.Report__of_repair.Add(newReport);
            var win = new Window2(context, newReport);
            win.ShowDialog();
            DataGridReport.ItemsSource = context.Report__of_repair.ToList();
        }
        public void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            var row = DataGridReport.SelectedItem as Report__of_repair;
            if (row == null)
            {
                MessageBox.Show("Сначала выберите строку");
                return;
            }
            MessageBoxResult result = MessageBox.Show("Вы уверены что хотите удалить эту строку данных?", "Подтверждение удаления",
                MessageBoxButton.YesNoCancel, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                context.Report__of_repair.Remove(row);
                context.SaveChanges();
                //ShowTable();   //почему то не хочет эта страка работать,выдаёт ошибку
            }
            DataGridReport.ItemsSource = context.Devices.ToList();
        }
        public void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            Button dtnEdit = sender as Button;
            var session = dtnEdit.DataContext as Report__of_repair;
            var win = new Window2(context, session);
            win.ShowDialog();
        }

        private void BtnReport_Click(object sender, RoutedEventArgs e)
        {
            Button btnReport = sender as Button;
            var session = btnReport.DataContext as Report__of_repair;
            var win = new Report_window(context, session);
            win.ShowDialog();
        }
    }
}
