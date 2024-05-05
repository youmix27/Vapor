using System;
using System.Collections.Generic;

namespace POCSQLCO.Models;

public partial class Jeu
{
    public int Id { get; set; }

    public string? Libelle { get; set; }

    public string? Description { get; set; }

    public decimal? Prix { get; set; }

    public DateOnly? DateDeSortie { get; set; }

    public int? DeveloppeurId { get; set; }

    public int? DistributeurId { get; set; }

    public bool? EstMultijoueur { get; set; }

    public bool? ContientGore { get; set; }

    public bool? ContientCs { get; set; }

    public string? Jaquette { get; set; }

    public virtual ICollection<ContenuCommande> ContenuCommandes { get; set; } = new List<ContenuCommande>();

    public virtual Developpeur? Developpeur { get; set; }

    public virtual Distributeur? Distributeur { get; set; }

    public virtual ICollection<Notation> Notations { get; set; } = new List<Notation>();

    public virtual ICollection<Genre> Genres { get; set; } = new List<Genre>();

    public virtual ICollection<Theme> Themes { get; set; } = new List<Theme>();

    /*
     * Renvoie le chemin d'accès de la jaquette
     */
    public string GetJeuSource()
    {
        return "img/jeux/" + this.Jaquette + ".jpg";
    }
}
