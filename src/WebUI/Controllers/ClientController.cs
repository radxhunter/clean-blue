using CleanArchitecture.Application.Clients.Commands.CreateClient;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.WebUI.Controllers;

public class ClientController : ApiControllerBase
{
    [HttpPost]
    public async Task<ActionResult<int>> Create(CreateClientCommand command)
    {
        return await Mediator.Send(command);
    }
}