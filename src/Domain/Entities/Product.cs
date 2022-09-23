using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Entities;
public class Product : BaseAuditableEntity
{
    public string Name { get; set; }
    public int? Number { get; set; }
    public int? Quantity { get; set; }
    public string? Description { get; set; }
    public decimal Price { get; set; }
    //public Order? Order { get; set; }
    //public Guid OrderId { get; set; }
}
