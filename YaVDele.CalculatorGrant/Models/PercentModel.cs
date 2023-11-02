using System.ComponentModel.DataAnnotations;

namespace YaVDele.CalculatorGrant.Models
{
    public class PercentModel
    {
        public double firstAmount { get; set; }
        [Range(0, 100, ErrorMessage = "Это проценты. Максимум 100, минимум 0.")]
        public int percent { get; set; }
    }
}
