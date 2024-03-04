using Shop_asp.Data.Interfaces;
using Shop_asp.Data.Models;

namespace Shop_asp.Data.mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories {
            get {
                return new List<Category> {
                    new Category { categoryName = "Електромобілі", categoryDesc = "Сучасний вид транспоорту" },
                    new Category { categoryName = "Класичні авто", categoryDesc = "Авто з ДВС" },

                };
            }
        }
    }
}
