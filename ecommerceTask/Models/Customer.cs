using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ecommerceTask.Models
{
    public class Customer
    {
        public int SSN { get; set; }
        public string Name { get; set; }
        public string email { get; set; }
        public int age { get; set; }
        public string adress { get; set; }
        public Boolean gender { get; set; }
        public DateTime birthdate { get; set; }

    }
}
