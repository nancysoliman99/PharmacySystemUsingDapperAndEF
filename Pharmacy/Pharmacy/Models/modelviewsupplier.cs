using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Models
{
    public class modelviewsupplier
    {
        public int SupplierId { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public string Address { get; set; }
        public int ProductId { get; set; }
        public string proName { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
    }
}
