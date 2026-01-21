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

namespace WpfAppDemo
{
    /// <summary>
    /// Interaction logic for Static3.xaml
    /// </summary>
    public partial class Static3 : Window
    {
        public Static3()
        {
            InitializeComponent();
        }
        private void btnColor_Click(object sender, RoutedEventArgs e)
        {
            SolidColorBrush colorBrush = new SolidColorBrush(Colors.Aqua);
            this.Resources["brush"] = colorBrush;

            
        }
    }
}
