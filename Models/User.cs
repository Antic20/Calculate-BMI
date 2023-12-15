using System.ComponentModel.DataAnnotations;

namespace CalculatorBMI.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
        public double BMI { get; set; }
    }

}
