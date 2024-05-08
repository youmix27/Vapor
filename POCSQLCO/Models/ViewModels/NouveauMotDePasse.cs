using System.ComponentModel.DataAnnotations;

namespace POCSQLCO.Models.ViewModels
{
    public class NouveauMotDePasse
    {

        [Required(ErrorMessage = "Veuillez préciser l'ancien mot de passe")]
        public string AncienPassword { get; set; }

        [Required(ErrorMessage = "Veuillez préciser le nouveau mot de passe")]
        [StringLength(30, ErrorMessage = "Le mot de passe doit faire 8 char minimum.", MinimumLength = 8)]
        public string NouveauPassword { get; set; }

        [Required(ErrorMessage = "Veuillez préciser la confirmation du nouveau mot de passe")]
        [Compare(nameof(NouveauPassword), ErrorMessage = "les deux mots de passes sont différents")]
        public string NouveauPassword2 { get; set; }

    }
}
