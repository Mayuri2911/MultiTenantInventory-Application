using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Product:ITenantEntity
    {
        public Guid Id { get; set; }
      
        public string Name { get; set; }

        public string Description { get; set; }
        public decimal Price { get; set; }

        public Guid TenantId { get; set; }              

        public Tenant Tenant { get; set; } = null!;
    }
}
