using System.ComponentModel.DataAnnotations;

namespace YaVDele.CalculatorGrant.Models
{
    public class PercentModel
    {
        public double firstAmount { get; set; }
        [Range(0, int.MaxValue)]
        public int percent { get; set; }
    }
}
