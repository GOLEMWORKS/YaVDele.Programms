using System.ComponentModel.DataAnnotations;
using YaVDele.CalculatorGrant.Models.Validation;

namespace YaVDele.CalculatorGrant.Models
{
    public class GrantCalculatorModel
    {
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Объём гранта не может быть отрицательным!")]
        public double grantAmount {  get; set; }

        [Required]
        [MaxAmountOfTeamHelpValidation]
        [Range(0, int.MaxValue, ErrorMessage = "Ваш вклад не может быть отрицательным!")]
        public double teamHelp {  get; set; }

        public bool ValidateTeamHelp()
        {
            if (teamHelp != 0 && ((grantAmount / 100) * 30) >= teamHelp) return true;
            return false;
        }

        public double MaxTeamHelp()
        {
            return (this.grantAmount / 100) * 30;
        }
    }
}
