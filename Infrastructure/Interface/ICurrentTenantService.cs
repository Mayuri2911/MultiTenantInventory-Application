using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interface
{
    public interface ICurrentTenantService
    {
        Guid? TenantId { get; }
        void SetCurrentTenant(Guid tenantId);
    }
}
