using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._09_Вступ_EF_CORE.Models
{
    /// <summary>
    ///3. Замовлення – Order
    ///1) + Id: Guid
    ///2) + Name: string
    ///3) + Create: datetime
    ///4) + Update: datetime
    ///5) + Description: string
    ///
    /// </summary>
    public class Order
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public DateTime Create {  get; set; }
        public DateTime Update { get; set; }
        public string Description { get; set; } = null!;
    }
}
