using System;
using System.Collections.Generic;

namespace Labb2_Databaser_RisbergsBokHandel.Entities;

public partial class TitlarPerFörfattare
{
    public string? AuthorName { get; set; }

    public int? Age { get; set; }

    public string? Status { get; set; }

    public int? Titles { get; set; }

    public int? InventoryValue { get; set; }
}
