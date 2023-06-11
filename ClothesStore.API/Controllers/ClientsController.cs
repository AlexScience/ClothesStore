using Microsoft.AspNetCore.Mvc;
using ClothesStore.API.Services;
using ClothesStore.Models.Models;

namespace ClothesStore.API.Controllers;

[ApiController]
[Route("[controller]")]
public class ClientsController : ControllerBase
{
    private readonly IEntityService<Client> _clientsEntityService;

    public ClientsController(IEntityService<Client> clientsEntityService)
    {
        _clientsEntityService = clientsEntityService;
    }

    [HttpGet("all")]
    public ActionResult<IEnumerable<Client>> GetAllClients()
    {
        var clients = _clientsEntityService.GetAll();
        return Ok(clients);
    }

    [HttpGet("id")]
    public ActionResult<IEnumerable<Client>> GetClientById(Guid clientId)
    {
        Client client = _clientsEntityService.GetById(clientId);
        return Ok(client);
    }

    [HttpPost]
    public void CreateClient(Client client)
    {
        _clientsEntityService.Create(client);
    }
}