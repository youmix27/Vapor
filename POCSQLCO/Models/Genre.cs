using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace POCSQLCO.Models;

public partial class Genre
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(20, ErrorMessage = "libelle trop long (max : 20 char)")]
    [RegularExpression(@"^[a-zA-Z0-9 éèà-]+$", ErrorMessage = "ne sont pas accepter les char spéciaux (hors tiret et espace)")]
    public string? Libelle { get; set; }

    public virtual ICollection<Jeu> Jeus { get; set; } = new List<Jeu>();
}
