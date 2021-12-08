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
    /// Логика взаимодействия для Window_devices.xaml
    /// </summary>
    public partial class Window_devices : Window
    {
        ESIR1Entities2 context;

        public Window_devices()
        {
            InitializeComponent();
            context = new ESIR1Entities2();
            DataGridSession.ItemsSource = context.Devices.ToList();
        }
        public void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            var newDevice = new Devices();
            context.Devices.Add(newDevice);
            var win = new Window1(context, newDevice);
            win.ShowDialog();
            DataGridSession.ItemsSource = context.Devices.ToList();
        }
        public void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            var row = DataGridSession.SelectedItem as Devices;
            if (row == null)
            {
                MessageBox.Show("Сначала выберите строку");
                return;
            }
            MessageBoxResult result = MessageBox.Show("Вы уверены что хотите удалить эту строку данных?", "Подтверждение удаления",
                MessageBoxButton.YesNoCancel, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                context.Devices.Remove(row);
                context.SaveChanges();
                //ShowTable();   //почему то не хочет эта страка работать,выдаёт ошибку
            }
            DataGridSession.ItemsSource = context.Devices.ToList();
        }
        public void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            Button dtnEdit = sender as Button;
            var session = dtnEdit.DataContext as Devices;
            var win = new Window1(context, session);
            win.ShowDialog();
        }
    }

}

