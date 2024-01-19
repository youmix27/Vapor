using System;
using System.Collections.Generic;

namespace POCSQLCO.Models;

public partial class Notation
{
    public int JeuId { get; set; }

    public int UtilisateurId { get; set; }

    public bool? Recommande { get; set; }

    public string? Commentaire { get; set; }

    public virtual Jeu Jeu { get; set; } = null!;

    public virtual Utilisateur Utilisateur { get; set; } = null!;
}
