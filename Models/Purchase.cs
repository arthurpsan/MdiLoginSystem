using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagementSystem.Models
{
    public class Purchase
    {
        public UInt64 Id { get; set; }

        public UInt64 Number { get; set; }
        public DateTime Beggining { get; set; }
        public DateTime Implementation { get; set; }
        public Decimal Comission { get; set; }

        public State State { get; set; } = State.PENDENT;

        
    }
}
