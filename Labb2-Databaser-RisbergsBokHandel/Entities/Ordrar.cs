using System;
using System.Collections.Generic;

namespace Labb2_Databaser_RisbergsBokHandel.Entities;

public partial class Ordrar
{
    public int OrderId { get; set; }

    public int? CustomerId { get; set; }

    public int? ButikId { get; set; }

    public virtual Butiker? Butik { get; set; }

    public virtual Kunder? Customer { get; set; }

    public virtual ICollection<OrderDetaljer> OrderDetaljers { get; set; } = new List<OrderDetaljer>();
}
