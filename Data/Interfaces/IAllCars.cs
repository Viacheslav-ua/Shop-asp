using Shop_asp.Data.Models;

namespace Shop_asp.Data.Interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> Cars { get; set; }
        IEnumerable<Car> FavoritesCars { get; set; }
        Car ObjectCar(int carId);
    }
}
