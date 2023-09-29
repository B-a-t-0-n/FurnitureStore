using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureStore
{
    public class ProductStorage
    {
        private List<Product> ListProducts;

        private static ProductStorage instance = new ProductStorage();

        public ProductStorage()
        {
            ListProducts = new List<Product>();
        }

        public ProductStorage(List<Product> products)
        {
            this.ListProducts = products;
        }

        public static ProductStorage GetInstance()
        {
            return instance;
        }

        public List<Product> GetListProducts()
        {
            return ListProducts;
        }
    }
}
