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

namespace WpfApp_Day8
{
    /// <summary>
    /// Interaction logic for TableData.xaml
    /// </summary>
    public partial class TableData : Window
    {
        public TableData()
        {
            InitializeComponent();
            
        }
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
             NorthwindEntities db = new NorthwindEntities();
            productDataGrid.DataContext = db.Products.ToList();

        }
        }
    }

