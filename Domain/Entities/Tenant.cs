using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Tenant
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;         
        public string Identifier { get; set; } = string.Empty;   
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
