using System.ComponentModel.DataAnnotations;

namespace POCSQLCO.Models.ViewModels
{
    public class NouvelUtilisateur
    {

        [Required]
        [StringLength(12, ErrorMessage = "Pseudo trop longue. (max char : 12)")]
        public string Pseudo { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Le mot de passe doit faire 8 char minimum.", MinimumLength = 8)]
        public string Password { get; set; }

        [Required]
        [Compare(nameof(Password), ErrorMessage = "Le mot de passe est différent.")]
        public string Password2 { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "Nom trop long (max : 20 char)")]
        public string Nom { get; set; }
        [StringLength(20, ErrorMessage = "Prenom trop long (max : 20 char)")]
        [Required]
        public string Prenom { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Adresse mail non valide.")]
        public string Email { get; set; }
        [Required]
        [StringLength(20, ErrorMessage = "Ville trop longue. (max char : 20)")]
        public string Ville { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Adresse trop longue. (max char : 100)")]
        public string Adresse { get; set; }
        [Required]
        [RegularExpression(@"^(?:0[1-9]|[1-8]\d|9[0-8]|2[ABab])\d{3}$", ErrorMessage = "Code postal invaldie")]
        public string CodePostal { get; set; }
        [Required]
        [RegularExpression(@"^0\d{9}$", ErrorMessage = "Numéro de téléphone invaldie")]
        public string Telephone { get; set; }

    }
}
