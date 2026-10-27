namespace Day3_1.Models
{
    public class Product
    {
        public int id { get; set; }
        public String? name { get; set; }
        public double price { get; set; }
        public String? description { get; set; }
        public int categoryId { get; set; }

        //navigation property
        public Category? category { get; set; }

    }
}
