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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        ESIR1Entities1 context;

        public Window1(ESIR1Entities1 context, Device devices)
        {
            InitializeComponent();

            this.context = context;
            CmbType.ItemsSource = context.Type_of_device.ToList();
            this.DataContext = devices;
            
        }
        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            context.SaveChanges();
            this.Close();
        }
    }


}
