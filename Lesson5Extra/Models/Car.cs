using Lesson5Extra.Enums;

namespace Lesson5Extra.Models
{
    public class Car: IComparable
    {
        /// <summary>
        /// Цвет машины
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Год выпуска
        /// </summary>
        public int YearsOfRelease 
        { 
            get 
            { 
                return _yearsOfRelease; 
            } 
            set 
            { 
                if(value < 1920 || value > DateTime.Now.Year)
                {
                    throw new ArgumentException("Некорректная дата выпуска");
                }

                _yearsOfRelease = value;
            } 
        }

        private int _yearsOfRelease;

        /// <summary>
        /// Пробег
        /// </summary>
        public int Mileage { get; set; }

        /// <summary>
        /// Двигатель машины
        /// </summary>
        public Engine Engine { get; set; }

        /// <summary>
        /// Модель машины
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// Марка машины
        /// </summary>
        public string Brand { get; set; }

        /// <summary>
        /// Коробка передач
        /// </summary>
        public TypeOfTransmission Transmission { get; set; }

        /// <summary>
        /// Привод
        /// </summary>
        public TypeOfActuator Actuator { get; set; }

        /// <summary>
        /// Руль
        /// </summary>
        public TypeOfHandlebar Handlebar { get; set; }  

        public string Vin { get; set; }

        /// <summary>
        /// Последнее время обновления данных
        /// </summary>
        public DateTime UpdateAt { get; set; }

        public int CountOfDoors { get; set; }

        public int CompareTo(object? obj)
        {
            var x = obj as Car;

            if (x == null)
            {
                throw new ArgumentException("obj is not a car");
            }

            if (Mileage != x.Mileage)
            {
                return 1;
            }

            if (UpdateAt != x.UpdateAt)
            {
                return 1;
            }

            return 0;
        }
    }
}

