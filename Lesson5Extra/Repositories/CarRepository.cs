using Lesson5Extra.Enums;
using Lesson5Extra.Models;

namespace Lesson5Extra.Repositories
{
    public class CarRepository
    {
        public List<Car> GetCars()
        {
            return new List<Car> {
                new Car()
                {
                    Color = "Black",
                    YearsOfRelease = 2018,
                    Mileage = 27_000,
                    Engine = new Engine()
                    {
                        Power = 351,
                        TypeOfOil = TypeOfOil.Electro
                    },
                    Brand = "Tesla",
                    Model = "Model 3 Long Range I",
                    Handlebar = TypeOfHandlebar.Left,
                    Actuator = TypeOfActuator.AllWhell,
                    Transmission = TypeOfTransmission.Automatic,
                    Vin = "WAUZZZ44ZEN096063",
                    UpdateAt = new DateTime(2021, 01, 01)
                },
                new Car()
                {
                    Color = "Black",
                    YearsOfRelease = 2007,
                    Mileage = 200_000,
                    Engine = new Engine()
                    {
                        Power = 358,
                        TypeOfOil = TypeOfOil.Oil
                    },
                    Brand = "Porsche",
                    Model = "Cayenne S I Рестайлинг (957)",
                    Handlebar = TypeOfHandlebar.Left,
                    Actuator = TypeOfActuator.AllWhell,
                    Transmission = TypeOfTransmission.Automatic,
                    Vin = "WAUZZZ44ZEN096075",
                    UpdateAt = new DateTime(2023, 01, 01)
                }
            };
        }

        public List<Car> GetChangedCars()
        {
            return new List<Car> {
                new Car()
                {
                    Color = "Black",
                    YearsOfRelease = 2018,
                    Mileage = 47_000,
                    Engine = new Engine()
                    {
                        Power = 351,
                        TypeOfOil = TypeOfOil.Electro
                    },
                    Brand = "Tesla",
                    Model = "Model 3 Long Range I",
                    Handlebar = TypeOfHandlebar.Left,
                    Actuator = TypeOfActuator.AllWhell,
                    Transmission = TypeOfTransmission.Automatic,
                    Vin = "WAUZZZ44ZEN096063",
                    UpdateAt = new DateTime(2023, 01, 01)
                },
                new Car()
                {
                    Color = "Black",
                    YearsOfRelease = 2007,
                    Mileage = 200_000,
                    Engine = new Engine()
                    {
                        Power = 358,
                        TypeOfOil = TypeOfOil.Oil
                    },
                    Brand = "Porsche",
                    Model = "Cayenne S I Рестайлинг (957)",
                    Handlebar = TypeOfHandlebar.Left,
                    Actuator = TypeOfActuator.AllWhell,
                    Transmission = TypeOfTransmission.Automatic,
                    Vin = "WAUZZZ44ZEN096075",
                    UpdateAt = new DateTime(2023, 01, 01)
                }
            };
        }
    }
}
