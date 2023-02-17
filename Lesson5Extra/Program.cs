using Lesson5Extra.Enums;
using Lesson5Extra.Models;
using Lesson5Extra.Repositories;

public class Program
{
    public static void Main(string[] args)
    {
        var repository = new CarRepository();
        var cars = repository.GetCars();
        var changedCars = repository.GetChangedCars();
        // если год обновления машины текущий, ничего не делать, 
        // если год не текущий, считаем разницу между текущим и последним годом и за каждый год прибавляем 10_000 км пробега
        // найти все машины которые мы изменили и вывести марку и модель машины, у которой мы обновили пробег в консоль

        //var t = cars.Where(x => x.UpdateAt.Year < DateTime.Now.Year).Single();
        //var r = DateTime.Now.Year - t.UpdateAt.Year;
        //r = r * 10_000;
        //t.Mileage = r + t.Mileage;
        //Console.WriteLine($"Марка машины: {t.Brand} Модель машины: {t.Model} Пробег: {t.Mileage}км ");

        var result = cars.Where(x => x.CompareTo(changedCars.Where(y => y.Vin == x.Vin).Single()) > 0).ToList();
        foreach (var item in result)
        {
            Console.WriteLine($"Измененная машина : Марка машины: {item.Brand} Модель машины: {item.Model}");
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