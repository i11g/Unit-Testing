using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store_Final
{
    public class Box
    {
        public Box()
        {
            this.Item = new();
        }

        public long SerialNumber { get; set; }

        public Item Item { get; set; }

        public int ItemQuantity { get; set; }

        public decimal BoxPrice { get; set; }
    }
}
