using System;
using System.Collections.Generic;

namespace DtabaseFirst.Models;

public partial class Order
{
    public Guid Id { get; set; }

    public string OrdersName { get; set; } = null!;

    public DateTime OrdersCreate { get; set; }

    public DateTime OrdersUpdate { get; set; }

    public string OrdersDescription { get; set; } = null!;
}
