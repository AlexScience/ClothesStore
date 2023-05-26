using ClothesStore.API.Services;
using ClothesStore.Models.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClothesStore.API.Controllers;

[ApiController]
[Route("[controller]")]
public class ClientsController : ControllerBase
{
    private readonly IClientsService _clientsService;

    public ClientsController(IClientsService clientsService)
    {
        _clientsService = clientsService;
    }

    [HttpGet("all")]
    public ActionResult<IEnumerable<Client>> GetAllClients()
    {
        var clients = _clientsService.GetAllClients();
        return Ok(clients);
    }

    [HttpPost]
    public void Create(Client client)
    {
        _clientsService.CreateClient(client);
    }
}