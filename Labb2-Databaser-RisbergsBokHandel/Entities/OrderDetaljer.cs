using System;
using System.Collections.Generic;

namespace Labb2_Databaser_RisbergsBokHandel.Entities;

public partial class OrderDetaljer
{
    public long Isbn { get; set; }

    public int OrderId { get; set; }

    public int Quantity { get; set; }

    public virtual Böcker IsbnNavigation { get; set; } = null!;

    public virtual Ordrar Order { get; set; } = null!;
}
