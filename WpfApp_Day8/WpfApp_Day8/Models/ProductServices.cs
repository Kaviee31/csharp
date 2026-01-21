using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp_Day8.Models

{
    public interface IProductService
    {
        ObservableCollection<Product> GetAllProducts();

        //write a method for adding product
          void addProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int productId);
    }

    internal class ProductServices : IProductService
        {
        NorthwindEntities db;
        public ProductServices()
        {
            db = new NorthwindEntities();
        }
        public ObservableCollection<Product> GetAllProducts()
        {
           
            var products = db.Products.ToList();
            return new ObservableCollection<Product>(products);
        }
        public void addProduct(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
        }

        public void updateProduct(Product product) {
            Product existingProduct = db.Products.Find(product.ProductID);
            if (existingProduct != null)
            {
                db.Entry(existingProduct).CurrentValues.SetValues(product);
                db.SaveChanges();   
            }
            //db.Products.Remove(existingProduct);
            //db.Products.Add(product);
        }

        public void deleteProduct(int productId) { 
            var product = db.Products.Find(productId);
            if (product != null)
            {
                db.Products.Remove(product);
                db.SaveChanges();
            }

        }
    }
    
}
