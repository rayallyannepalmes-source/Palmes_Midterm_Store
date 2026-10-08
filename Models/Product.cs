namespace Palmes_Midterm_Store.Models
{
    public class Product
    {
        public int ID { get; set; }

        public string Name { get; set; } = "";

        public string Description { get; set; } = "";

        public decimal Price { get; set; }

        public string Category { get; set; } = "";
    }
}

namespace Palmes_Midterm_Store.Models
{
    public class CartItem
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}