using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DapperMVCDemo.Models
{
    public class OrderDetail
    {
        public Guid OrderDetailId { get; set; }
        public Guid OrderId { get; set; }
        public string ProductName { get; set; }
        public string Count { get; set; }
        public decimal Prcie { get; set; }
        
    }
}
