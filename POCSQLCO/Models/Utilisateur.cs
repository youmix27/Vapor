using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace POCSQLCO.Models;

public partial class Utilisateur
{
    [Key]
    public int Id { get; set; }
    [Required(AllowEmptyStrings = false, ErrorMessage = "veuillez remplir ce champ")]
    [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "caractères non autorisés utilisés")]
    public string? Nom { get; set; }
    [Required(AllowEmptyStrings = false, ErrorMessage = "veuillez remplir ce champ")]
    [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$", ErrorMessage = "caractères non autorisés utilisés")]
    public string? Prenom { get; set; }
    [Required(AllowEmptyStrings = false, ErrorMessage = "veuillez remplir ce champ")]
    public string? Pseudo { get; set; }
    [Required(AllowEmptyStrings = false, ErrorMessage = "veuillez remplir ce champ")]
    public string? HashMdp { get; set; }
    [Required(AllowEmptyStrings = false, ErrorMessage = "veuillez remplir ce champ")]
    [EmailAddress(ErrorMessage = "veuillez renseigner un email valide")]
    public string? Email { get; set; }
    [Required(AllowEmptyStrings = false, ErrorMessage = "veuillez remplir ce champ")]
    public string? Ville { get; set; }
    [Required(AllowEmptyStrings = false, ErrorMessage = "veuillez remplir ce champ")]
    public string? Adresse { get; set; }
    [Required(AllowEmptyStrings = false, ErrorMessage = "veuillez remplir ce champ")]
    [RegularExpression(@"^(?:0[1-9]|[1-8]\d|9[0-8]|2[ABab])\d{3}$", ErrorMessage = "Code postal invaldie")]
    public string? CodePostal { get; set; }
    [Required(AllowEmptyStrings = false, ErrorMessage = "veuillez remplir ce champ")]
    [RegularExpression(@"^0\d{9}$", ErrorMessage = "veuillez renseigner un numéro de téléphone valide")]
    public string? Telephone { get; set; }

    public bool FiltreGore { get; set; }

    public bool FiltreCs { get; set; }

    public bool IsAdmin { get; set; }

    public string? Salt { get; set; }

    public virtual ICollection<Commande> Commandes { get; set; } = new List<Commande>();

    public virtual ICollection<Notation> Notations { get; set; } = new List<Notation>();
}
