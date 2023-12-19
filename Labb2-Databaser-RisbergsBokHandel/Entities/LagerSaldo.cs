using System;
using System.Collections.Generic;

namespace Labb2_Databaser_RisbergsBokHandel.Entities;

public partial class LagerSaldo
{
    public int StoreId { get; set; }

    public long Isbn { get; set; }

    public int? Quantity { get; set; }

    public virtual Böcker IsbnNavigation { get; set; } = null!;

    public virtual Butiker Store { get; set; } = null!;
}
