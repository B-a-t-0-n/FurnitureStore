using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureStore
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string TypeFurniture { get; set; }
        public decimal Price { get; set; }
        public byte[]? Image { get; set; }

        public Product(int ProductId, string ProductName, string TypeFurniture, decimal Price, byte[]? Image) 
        {
            this.ProductId = ProductId;
            this.ProductName = ProductName;
            this.TypeFurniture = TypeFurniture; 
            this.Price = Price;
            if(Image != null )
                this.Image = Image;
            else
            {
                Bitmap bitmap = Properties.Resources._1;
                byte[] bytes;
                using (MemoryStream stream = new MemoryStream())
                {
                    bitmap.Save(stream, ImageFormat.Bmp);
                    bytes = stream.ToArray();
                }

                this.Image = bytes;
            }
                
        }
    }
}
