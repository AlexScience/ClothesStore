using Microsoft.AspNetCore.Mvc;
using ClothesStore.API.Services;
using ClothesStore.Models.Models;

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

    [HttpGet("id")]
    public ActionResult<IEnumerable<Client>> GetClientById(Guid clientId)
    {
        Client client = _clientsService.GetClientById(clientId);
        return Ok(client);
    }
    
    [HttpPost]
    public void Create(Client client)
    {
        _clientsService.CreateClient(client);
    }
}