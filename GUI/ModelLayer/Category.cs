using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.ModelLayer
{
    public class Category
    {
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
