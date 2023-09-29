using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureStore
{
    public class Basket
    {
        public int ProductId { get; set; }
        public int Count { get; set; }

        public Basket(int ProductId, int Count) 
        {
            this.ProductId = ProductId;
            this.Count = Count;
        }
    }
}
