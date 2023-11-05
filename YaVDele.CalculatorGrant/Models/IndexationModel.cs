using System.ComponentModel.DataAnnotations;
using YaVDele.CalculatorGrant.Models.Validation;

namespace YaVDele.CalculatorGrant.Models
{
    public class IndexationModel
    {
        [Range(0, int.MaxValue)]
        public double priceBefore { get; set; }
        [Range(0, int.MaxValue)]
        public double priceAfter { get; set; }
        [Range(1, int.MaxValue)]
        public int quantity { get; set; }
    }
}
