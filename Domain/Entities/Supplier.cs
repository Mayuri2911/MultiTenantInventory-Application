using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Supplier : ITenantEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public string ContactPerson { get; set; }

        public string Email { get; set; }

        public Guid TenantId { get; set; }

    }
}
