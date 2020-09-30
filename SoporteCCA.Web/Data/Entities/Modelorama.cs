using System.ComponentModel.DataAnnotations;

namespace SoporteCCA.Web.Data.Entities
{
    public class Modelorama
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(3)]
        public string Key { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(60)]
        [Display(Name = "Commission Agent")]
        public string CommissionAgent { get; set; }
    }
}
