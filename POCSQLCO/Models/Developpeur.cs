using System;
using System.Collections.Generic;

namespace POCSQLCO.Models;

public partial class Developpeur
{
    public int Id { get; set; }

    public string? Libelle { get; set; }

    public string? Description { get; set; }

    public string? Logo { get; set; }

    public virtual ICollection<Jeu> Jeus { get; set; } = new List<Jeu>();
}
