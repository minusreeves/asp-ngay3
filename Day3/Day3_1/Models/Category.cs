namespace Day3_1.Models
{
    public class Category
    {
        public int id { get; set; }
        public String? name { get; set; }

        //navigation property
        public List<Product>? products { get; set; }

    }
}
