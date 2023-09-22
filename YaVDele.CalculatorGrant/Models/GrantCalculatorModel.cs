using System.ComponentModel.DataAnnotations;

namespace YaVDele.CalculatorGrant.Models
{
    public class GrantCalculatorModel
    {
        [Range(0, int.MaxValue, ErrorMessage = "Объём гранта не может быть отрицательным!")]
        double grantAmount {  get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "Ваш вклад не может быть отрицательным!")]
        double teamHelp {  get; set; }
    }
}
