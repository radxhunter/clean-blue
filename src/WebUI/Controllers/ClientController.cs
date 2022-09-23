using CleanArchitecture.Application.Clients.Commands.CreateClient;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.WebUI.Controllers;

public class ClientController : ApiControllerBase
{
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
    }

    [HttpPost]
    public async Task<ActionResult<int>> Create(CreateClientCommand command)
    {
        return await Mediator.Send(command);
    }

    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
