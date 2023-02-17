using Lesson5Extra.Repositories;

public class Program
{
    public static void Main(string[] args)
    {
        var repository = new CarRepository();
        var cars = repository.GetCars();
        var changedCars = repository.GetChangedCars();
        var result = cars.Where(x => x.CompareTo(changedCars.Where(y => y.Vin == x.Vin).Single()) > 0).ToList();
        foreach (var item in result)
        {
            Console.WriteLine($"Измененная машина: Марка машины: {item.Brand} Модель машины: {item.Model}");
        }

        foreach (var car in cars)
        {
            foreach (var changedCar in changedCars)
            {
                if (car.Vin == changedCar.Vin)
                {
                    int res = car.CompareTo(changedCar);
                    if (res > 0)
                    {
                        Console.WriteLine($"Марка машины: {car.Brand} Модель машины: {car.Model}");
                    }
                }
            }
        }

        Console.ReadKey();
    }
}