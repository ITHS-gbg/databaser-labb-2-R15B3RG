using System;
using System.Collections.Generic;

namespace Labb2_Databaser_RisbergsBokHandel.Entities;

public partial class Böcker
{
    public long Isbn { get; set; }

    public string? Title { get; set; }

    public string? Language { get; set; }

    public int? Price { get; set; }

    public int? ReleaseDate { get; set; }

    public int? FörfattareId { get; set; }

    public string? FörfattareFirstName { get; set; }

    public string? FörfattareLastName { get; set; }

    public virtual Författare? Författare { get; set; }

    public virtual ICollection<LagerSaldo> LagerSaldos { get; set; } = new List<LagerSaldo>();

    public virtual ICollection<OrderDetaljer> OrderDetaljers { get; set; } = new List<OrderDetaljer>();
}
