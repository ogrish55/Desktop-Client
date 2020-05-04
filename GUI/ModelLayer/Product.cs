
namespace GUI.ModelLayer
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int ProductId { get; set; }
        public int AmountOnStock { get; set; }
        public string Brand { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Price} - {ProductId} - {Brand}";
        }
    }
}
