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
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        ESIR1Entities2 context;
        public Window2(ESIR1Entities2 context, Report__of_repair report)
        {
            InitializeComponent();
            this.context = context;
            CmbDevice.ItemsSource = context.Devices.ToList();
            CmbEmployee.ItemsSource = context.Staff.ToList();
            CmbStatus.ItemsSource = context.Status_of_repair.ToList();
            CmbType.ItemsSource = context.Type_of_problem.ToList();
            this.DataContext = report;
        }
        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            context.SaveChanges();
            this.Close();
        }
    }
}
