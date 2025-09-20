using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Code First
///1. Магазин – Product
///1) + Id: Guid
///2) + Name: string
///3) + Cost: double
///4) + Description: string
///5) + Quantity: int
/// </summary>
/// <param name="args"></param>
namespace _02._09_Вступ_EF_CORE.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public double Cost { get; set; }
        public string? Description { get; set; } = null;
        public int Quantity { get; set; }


    }
}
