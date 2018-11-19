using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerceTask.Models
{
    public class order
    {
        public int cid { get; set; }
        public int quantity { get; set; }
        public decimal price { get; set; }
        public DateTime orderDate { get; set; }
        public decimal discount { get; set; }
        public DateTime Deliverytime { get; set; }



    }
}
