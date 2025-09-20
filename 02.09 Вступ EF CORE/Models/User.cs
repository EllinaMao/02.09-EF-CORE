using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._09_Вступ_EF_CORE.Models
{
    /// <summary>
    /// 2. Користувач – User
    ///1) + Id: Guid
    ///2) + Name: string
    ///3) + LastName: string
    ///4) + Login: string
    ///5) + Password: string
    ///6) + Email: string
    ///
    /// </summary>
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }= null!;
        public string LastName { get; set; }= null!;
        public string Login { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string? Email { get; set; }

    }
}
