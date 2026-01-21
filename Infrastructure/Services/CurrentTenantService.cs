using Infrastructure.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class CurrentTenantService : ICurrentTenantService
    {
      
            public Guid? TenantId { get; private set; }

            public void SetCurrentTenant(Guid tenantId)
            {
                TenantId = tenantId;
            }
        }
    }

