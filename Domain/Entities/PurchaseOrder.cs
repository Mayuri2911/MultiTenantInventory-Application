using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PurchaseOrder : ITenantEntity
    {

        public Guid Id { get; set; }
        public string PurchaseOrderNumber { get; set; }

        public DateTime OrderDate { get; set; }

        public decimal TotalAmount { get; set; }
        public Guid TenantId { get; set; }
    }
}
