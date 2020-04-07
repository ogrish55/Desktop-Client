using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.ModelLayer
{
    public class Order
    {
        public int OrderId { get; set; }
        public decimal FinalPrice { get; set; }

        public EnumOrderStatus Status { get; set; }

        public DateTime Date { get; set; }

        public Discount CurrentDiscount { get; set; }

        public EnumPaymentMethods PaymentMethod { get; set; }

        public int CustomerId { get; set; }

        public Order()
        {
            Date = DateTime.Now;
            Status = EnumOrderStatus.Active;
        }
    }
}
