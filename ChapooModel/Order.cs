using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    public class Order
    {
        public int OrderId { get; set; }
        public Tafel Tafel { get; set; }
        public decimal TotaalPrijs { get; set; }
        public Account Gebruiker { get; set; }
        public string Opmerking { get; set; }
    }
}
