using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapooModel
{
    public class MenuItem
    {
        public int MenuItemId { get; set; }
        public string MenuItemNaam { get; set; }
        public int Voorraad { get; set; }
        public decimal Prijs { get; set; }
        public bool IsAlcoholisch { get; set; }
        public int CategorieId { get; set; }
    }
}
