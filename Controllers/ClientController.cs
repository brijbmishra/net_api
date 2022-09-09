using Microsoft.AspNetCore.Mvc;
using net_api.Managers;

namespace net_api.Controllers;

[ApiController]
[Route("[controller]")]
public class ClientController : ControllerBase
{
    private readonly ILogger<ClientController> _logger;
    private readonly IClient _client;

    public ClientController(ILogger<ClientController> logger, IClient client)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _client = client ?? throw new ArgumentNullException(nameof(client));
    }

    [HttpGet()]
    public IActionResult Get()
    {
        var result = _client.GetAllClients();

        return Ok(result);
    }
}