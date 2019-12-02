using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperMVCDemo.Models
{
    public class Order
    {
        public Guid OrderId { get; set; }
        public string OrderCode { get; set; }
        public string Address { get; set; }
        public string UserName { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
