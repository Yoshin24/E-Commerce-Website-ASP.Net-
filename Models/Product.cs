namespace OkZim.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductCategory { get; set; }
        public string ProductDescription { get; set; }
        public decimal ProductPrice { get; set; }
        public int Quantity { get; set; }
        public string ProductBrand { get; set; }
        public string imageUrl { get; set; }

        public Product()
        {


        }
    }
}
