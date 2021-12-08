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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       // ESIR1Entities1 context;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnDevices_Click(object sender, RoutedEventArgs e)
        {
            Window_devices window_Devices = new Window_devices();
            window_Devices.Show();
            
        }

        private void btnTable_Click(object sender, RoutedEventArgs e)
        {
            Window_Report window_Report = new Window_Report();
            window_Report.Show();
        }

        private void btnReport_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
