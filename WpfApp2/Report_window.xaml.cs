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
    /// Логика взаимодействия для Report_window.xaml
    /// </summary>
    public partial class Report_window : Window
    {
        ESIR1Entities1 context;

        public Report_window(ESIR1Entities1 context, Report__of_repair report)
        {
            InitializeComponent();
            this.context = context;
            CmbNumber.ItemsSource = context.Report__of_repair.ToList();
            this.DataContext = report;
        }

        private void CmbNumber_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
