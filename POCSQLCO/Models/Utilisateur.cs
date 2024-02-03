using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace POCSQLCO.Models;

public partial class Utilisateur
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string? Nom { get; set; }
    [Required]
    public string? Prenom { get; set; }
    [Required]
    public string? Pseudo { get; set; }
    [Required]
    public string? HashMdp { get; set; }
    [Required]
    public string? Email { get; set; }
    [Required]
    public string? Ville { get; set; }
    [Required]
    public string? Adresse { get; set; }
    [Required]
    public string? CodePostal { get; set; }
    [Required]
    public string? Telephone { get; set; }

    public bool FiltreGore { get; set; }

    public bool FiltreCs { get; set; }

    public bool IsAdmin { get; set; }

    public string? Salt { get; set; }

    public virtual ICollection<Commande> Commandes { get; set; } = new List<Commande>();

    public virtual ICollection<Notation> Notations { get; set; } = new List<Notation>();
}
