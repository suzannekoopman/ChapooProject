using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    public class OrderItem
    {
        public Order Order { get; set; }
        public int OrderItemId { get; set; }
        public int Aantal { get; set; }
        public DateTime BestelTijd { get; set; }
        public int OrderStatusId { get; set; }
        public int MenuItemId { get; set; }
    }
}
