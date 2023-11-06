using System.ComponentModel.DataAnnotations;
using YaVDele.CalculatorGrant.Models.Validation;

namespace YaVDele.CalculatorGrant.Models
{
    public class IndexationModel
    {
        [Range(0, int.MaxValue, ErrorMessage = "Цена не может быть отрицательной")]
        public double priceBefore { get; set; }
        [Range(0, int.MaxValue)]
        public double priceAfter { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Минимальное значение = 1")]
        public int quantity { get; set; } = 1;
    }
}
