using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.ModelLayer
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int ProductId { get; set; }

        public int AmountOnStock { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Price} - {ProductId}";
        }
    }


}
