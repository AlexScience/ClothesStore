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
        var client = _clientsEntityService.GetById(clientId);
        return client == null ? NotFound("Клиент не найден") : Ok(client);
    }

    [HttpPost]
    public void CreateClient(Client client)
    {
        _clientsEntityService.Create(client);
    }
}