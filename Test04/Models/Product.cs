namespace Test04.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public DateTime DateExp { get; set; }
        public double? Price { get; set; }
        public int? Qty { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
