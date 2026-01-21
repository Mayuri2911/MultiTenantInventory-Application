using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public  class Inventory : ITenantEntity
    {
        public Guid Id { get; set; }

        public int QuantityAvailable { get; set; }

        public int QuantityReserved { get; set; }

        public Guid TenantId { get; set; }
        public Guid ProductId { get; set; }
    }
}
