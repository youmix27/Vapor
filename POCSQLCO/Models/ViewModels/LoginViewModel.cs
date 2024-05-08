using System.ComponentModel.DataAnnotations;

namespace POCSQLCO.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Veuillez remplir ce champ.")]
        public string? Pseudo { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Veuillez remplir ce champ.")]
        public string? Password { get; set; }

    }
}
