using Shop_asp.Data.Models;

namespace Shop_asp.Data.Interfaces
{
    public interface ICarsCategory
    {
        IEnumerable<Category> AllCategories {  get; }
    }
}
