using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for Collection.xaml
    /// </summary>
    public partial class Collection : Window
    { ObservableCollection<ProductInfo> ProductList= new ObservableCollection<ProductInfo>();
        public Collection()
        {
            InitializeComponent();

            ProductList = new ObservableCollection<ProductInfo>()
            {
                new ProductInfo(){ ProductId=101, ProductName="Laptop", ProductPrice=45000 },
                new ProductInfo(){ ProductId=102, ProductName="Mobile", ProductPrice=25000 },
                new ProductInfo(){ ProductId=103, ProductName="Tablet", ProductPrice=15000 },
                new ProductInfo(){ ProductId=104, ProductName="SmartWatch", ProductPrice=8000 },
                new ProductInfo(){ ProductId=105, ProductName="HeadPhone", ProductPrice=3000 },
            };
            datagridProducts.ItemsSource = ProductList;

            
        }private void btnAdd_Click (Object sender, RoutedEventArgs e)
        {
            ProductInfo productInfo = new ProductInfo();
            productInfo.ProductId = Convert.ToInt32(txtId.Text);
            productInfo.ProductName = txtName.Text;
            productInfo.ProductPrice = Convert.ToDouble(txtPrice.Text);
            ProductList.Add(productInfo);
            datagridProducts.Items.Refresh();   

        }
    }
}
