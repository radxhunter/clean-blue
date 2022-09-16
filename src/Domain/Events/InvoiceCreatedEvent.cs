using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Domain.Events;
public class InvoiceCreatedEvent : BaseEvent
{

    public InvoiceCreatedEvent(Invoice invoice)
    {
        Invoice = invoice;
    }
    public Invoice Invoice { get; }

}
