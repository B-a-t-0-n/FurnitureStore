using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureStore
{
    public class ProductsRepository
    {
        private List<Product> productsStorage;

        public ProductsRepository()
        {
            productsStorage = ProductStorage.GetInstance().GetListProducts();
        }

        public List<Product> GetAll()
        {
            return productsStorage;
        }

        public Product GetProduct(int id)
        {
            Product product = null;
            foreach (var pr in productsStorage) 
            {
                if(pr.ProductId == id)
                {
                    product = pr;
                }
            }
            return product;
        }

        public int GetIdLastProduct()
        {
            return productsStorage[productsStorage.Count - 1].ProductId;
        }

        public void Add(Product product)
        {
            //можно добавить вывод информации
            productsStorage.Add(product);
        }

        public void Remove(Product product)
        {
            //можно добавить вывод информации
            productsStorage.Remove(product);
        }

        public void Update(int idProduct, string meaning, string inMeaning)
        {
            Product product = GetProduct(idProduct);
            Product productCopy = product;

            switch (meaning)
            {
                case "name":
                    productCopy = new Product(product.ProductId, inMeaning, product.TypeFurniture , product.Price, product.Image);
                    break;

                case "type":
                    productCopy = new Product(product.ProductId, product.ProductName, inMeaning , product.Price, product.Image);
                    break;

                case "price":
                    decimal price;
                    decimal.TryParse(inMeaning, out price);
                    productCopy = new Product(product.ProductId, product.ProductName, product.TypeFurniture, price, product.Image);
                    break;
            }
            //добавить информацию об обновлении
            productsStorage[product.ProductId - 1] = productCopy;
        }

        public void UpdateImage(int idProduct, Bitmap image)
        {
            Product product = GetProduct(idProduct);
            Product productCopy = product;

            byte[] bytes;
            using (MemoryStream stream = new MemoryStream())
            {
                image.Save(stream, ImageFormat.Bmp);
                bytes = stream.ToArray();
            }
            productCopy = new Product(product.ProductId, product.ProductName, product.TypeFurniture, product.Price, bytes);
            productsStorage[product.ProductId - 1] = productCopy;
        }


    }
}
