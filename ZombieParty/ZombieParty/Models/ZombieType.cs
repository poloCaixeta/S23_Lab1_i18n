using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ZombieParty.Models
{
    public class ZombieType
    {
        public int Id { get; set; }
        [DisplayName("Type Name")]
        [StringLength(25, MinimumLength = 5)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} has to be filled.")]
        public string TypeName { get; set; }

       
        [Display(Name = "Point")]
        [Range(1, 20, ErrorMessage = "RangeValidation")]
        public int Point { get; set; }
        [ValidateNever]
        public virtual List<Zombie>? Zombies { get; set; }
    }
}
