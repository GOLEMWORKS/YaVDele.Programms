using System.ComponentModel.DataAnnotations;
using YaVDele.CalculatorGrant.Models;

namespace YaVDele.CalculatorGrant.Models.Validation
{
    public class MaxAmountOfTeamHelpValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object? value, ValidationContext validationContext)
        {
            var teamHelpState = validationContext.ObjectInstance as GrantCalculatorModel;

            if (teamHelpState != null)
            {
                if (!teamHelpState.ValidateTeamHelp())
                {
                    return new ValidationResult($"Объём вашего вклада не может превышать 30% от объёма гранта. Максимальный объём вклада составит {teamHelpState.MaxTeamHelp().ToString("c", new System.Globalization.CultureInfo("ru-RU"))}", 
                        new[] {validationContext.MemberName});
                }
            }

            return ValidationResult.Success;
        }
    }
}
