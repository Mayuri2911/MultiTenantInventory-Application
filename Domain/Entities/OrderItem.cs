using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class OrderItem : ITenantEntity
    {
        public Guid Id { get; set; }

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public decimal Subtotal { get; set; }

        public Guid TenantId { get; set; }
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }


    }
}
