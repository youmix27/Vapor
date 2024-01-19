using System;
using System.Collections.Generic;

namespace POCSQLCO.Models;

public partial class Theme
{
    public int Id { get; set; }

    public string? Libelle { get; set; }

    public virtual ICollection<Jeu> Jeus { get; set; } = new List<Jeu>();
}
