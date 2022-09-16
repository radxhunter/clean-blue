using CleanArchitecture.Application.Common.Security;
using CleanArchitecture.Application.Invoices.Commands.CreateInvoice;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.WebUI.Controllers;

[Authorize]
public class InvoiceController : ApiControllerBase
{
    [HttpPost]
    public async Task<ActionResult<int>> Create(CreateInvoiceCommand command)
    {
        return await Mediator.Send(command);
    }
}
