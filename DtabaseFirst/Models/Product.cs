using System;
using System.Collections.Generic;

namespace DtabaseFirst.Models;

public partial class Product
{
    public Guid Id { get; set; }

    public string ProductsName { get; set; } = null!;

    public double ProductsCost { get; set; }

    public string? ProductsDescription { get; set; }

    public int ProductsQuantity { get; set; }
}
