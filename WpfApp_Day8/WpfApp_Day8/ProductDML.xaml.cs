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
using WpfApp_Day8.Models;

namespace WpfApp_Day8
{
    /// <summary>
    /// Interaction logic for ProductDML.xaml
    /// </summary>
    public partial class ProductDML : Window
    {
        IProductService productService;
        ObservableCollection<Product> products;

        public ProductDML()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
           productService = new ProductServices();
        }

        private void mainGridLoaded(object sender, RoutedEventArgs e)
        {
            products = new ObservableCollection<Product>(productService.GetAllProducts());
            lstItems.DataContext = products;
        }

        private void lstItems_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            maingrid.DataContext = lstItems.SelectedValue as Product;

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            products.Add(new Product());
            lstItems.SelectedIndex = products.Count - 1;
            txtProdid.Focus();
            btnSave.IsEnabled = true;
            btnAdd.IsEnabled = false;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            Product selectedProduct = lstItems.SelectedItem as Product;
            productService.addProduct(selectedProduct);
            products.Add(selectedProduct);
            lstItems.Items.Refresh();
            btnSave.IsEnabled = false;
            btnAdd.IsEnabled = true;

        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            var editedProduct = lstItems.SelectedItem as Product;
            productService.UpdateProduct(editedProduct);
            lstItems.Items.Refresh();
            MessageBox.Show("Product updated successfully");

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            Product selectedProduct = lstItems.SelectedItem as Product;
            productService.DeleteProduct(selectedProduct.ProductID);
            products.Remove(selectedProduct);
            lstItems.Items.Refresh();
            MessageBox.Show("Product deleted successfully");

        }
    }
}
