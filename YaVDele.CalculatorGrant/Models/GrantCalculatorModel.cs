using System.ComponentModel.DataAnnotations;

namespace YaVDele.CalculatorGrant.Models
{
    public class GrantCalculatorModel
    {
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Объём гранта не может быть отрицательным!")]
        public double grantAmount {  get; set; }
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Ваш вклад не может быть отрицательным!")]
        public double teamHelp {  get; set; }
    }
}
