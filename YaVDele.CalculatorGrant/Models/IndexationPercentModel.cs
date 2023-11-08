using System.ComponentModel.DataAnnotations;
using YaVDele.CalculatorGrant.Models.Validation;

namespace YaVDele.CalculatorGrant.Models
{
    public class IndexationPercentModel
    {
        [Range(1, int.MaxValue, ErrorMessage = "Цена не может быть отрицательной или равной нулю!")]
        public double priceBefore { get; set; }
        [Required(ErrorMessage = "Укажите процент изменения!")]
        public double indexationPercent { get; set; }
        public int quantity { get; set; } = 1;
    }
}
