using System.ComponentModel.DataAnnotations;
using YaVDele.CalculatorGrant.Models.Validation;

namespace YaVDele.CalculatorGrant.Models
{
    public class PercentCalcModel
    {
        public double firstAmount { get; set; }
        public double secondAmount { get; set; } = 0;
        [Range(0, 100, ErrorMessage = "Это проценты. Максимум 100, минимум 0.")]
        public int firstPercent { get; set; }
        [Range(0, 100, ErrorMessage = "Это проценты. Максимум 100, минимум 0.")]
        public int secondPercent { get; set; }
    }
}
