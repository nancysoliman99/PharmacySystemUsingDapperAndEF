using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy.Models
{
    public class Sale
    {
        public int SaleId { get; set; }
        public int CustomerId { get; set; }
        public DateTime SaleDate { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual List<SaleDetail> SaleDetails { get; set; }
    }
}
