using System;
using System.Collections.Generic;

namespace POCSQLCO.Models;

public partial class ContenuCommande
{
    public int CommandeId { get; set; }

    public int UtilisateurId { get; set; }

    public int JeuId { get; set; }

    public virtual Commande Commande { get; set; } = null!;

    public virtual Jeu Jeu { get; set; } = null!;
}
