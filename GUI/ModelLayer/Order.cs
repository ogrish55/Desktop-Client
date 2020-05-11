using System;

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

        public override string ToString()
        {
            return $"OrderId: {OrderId} - Status: {Status.ToString()}";
        }
    }
}
