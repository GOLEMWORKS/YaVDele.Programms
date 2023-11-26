using System.ComponentModel.DataAnnotations;
using YaVDele.CalculatorGrant.Models.Validation;

namespace YaVDele.CalculatorGrant.Models
{
    public class AddUpdateJobPageModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string JobName { get; set; }
        [Required]
        public double Salary { get; set; }
    }
}
