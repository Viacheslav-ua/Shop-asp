namespace Shop_asp.Data.Models
{
    public class Car
    {
        public int id { get; set; }
        public string name { get; set; }
        public string shortDesc { get; set; }
        public string longDesc { get; set; }
        public string img { get; set; }
        public ushort price { get; set; }
        public bool isFavorite { get; set; }
        public int available { get; set; }
        public int categoryId { get; set; }
        public string categoryName { get; set; }
        public virtual Category Category { get; set; }
    }
}
