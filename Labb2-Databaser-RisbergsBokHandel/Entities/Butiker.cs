using System;
using System.Collections.Generic;

namespace Labb2_Databaser_RisbergsBokHandel.Entities;

public partial class Butiker
{
    public int Id { get; set; }

    public string? StoreName { get; set; }

    public string? Adresses { get; set; }

    public virtual ICollection<LagerSaldo> LagerSaldos { get; set; } = new List<LagerSaldo>();

    public virtual ICollection<Ordrar> Ordrars { get; set; } = new List<Ordrar>();
}
