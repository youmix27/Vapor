using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace POCSQLCO.Models;

public partial class Commande
{
    [Key]
    public int Id { get; set; }

    [Key]
    public int UtilisateurId { get; set; }

    public DateOnly? Date { get; set; }

    public bool EstTermine { get; set; }

    public virtual ICollection<ContenuCommande> ContenuCommandes { get; set; } = new List<ContenuCommande>();

    public virtual Utilisateur Utilisateur { get; set; } = null!;
}
