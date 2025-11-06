using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagementSystem.Models
{
    public class Purchase
    {
        public UInt64? Id { get; set; }

        public UInt64? Number { get; set; }
        public DateTime? Beggining { get; set; }
        public DateTime? Implementation { get; set; }
        public Decimal? Comission { get; set; }

        // state relationship
        public State State { get; set; } = State.PENDENT;

        // relationships with other classes
        public Seller? Seller { get; set; }
        public Customer? Customer { get; set; }
        public List<Payment>? Payment { get; set; }

        public Item? Item { get; set; }

        
    }
}
