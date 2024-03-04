namespace Shop_asp.Data.Models
{
    public class Category
    {
        public int id { get; set; }
        public string? categoryName { get; set; }
        public string? categoryDesc { get; set;}
        public List<Car> cars { get; set;}
         
    }
}

