namespace OkZim.Models
{
    public class Cart
    {
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice => ProductPrice * Quantity;

        // Navigation property
        public virtual Product Product { get; set; }
    
    }
}
