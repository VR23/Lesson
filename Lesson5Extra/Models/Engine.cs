using Lesson5Extra.Enums;

namespace Lesson5Extra.Models
{
    public class Engine
    {
        /// <summary>
        /// Можность двигателя в лошадиных силах
        /// </summary>
        public int Power { get; set; }

        /// <summary>
        /// Тип используемого топлива
        /// </summary>
        public TypeOfOil TypeOfOil { get; set; }
    }
}
