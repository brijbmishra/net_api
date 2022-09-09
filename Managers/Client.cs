using resources = net_api.Resources;

namespace net_api.Managers;

public class Client : IClient
{
    private readonly resources.IClient _client;

    public Client(resources.IClient client)
    {
        _client = client ?? throw new ArgumentNullException(nameof(client));
    }

    public List<net_api.Models.Manager.Client> GetAllClients()
    {
        var resources = _client.GetAllClients();

        var result = resources.Select(r=>new net_api.Models.Manager.Client() {
            ClientId = r.ClientID.Trim(),
            ClientAccessKey = r.ClientAccessKey.Trim(),
            ClientAuditId = r.ClientsAuditId,
            ContactNo = r.ContactNo?.Trim(),
            Name = r.Name.Trim()
        }).ToList();

        return result;
    }
}

public interface IClient
{
    List<net_api.Models.Manager.Client> GetAllClients();
}