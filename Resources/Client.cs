using System.Data;
using Dapper;
using System.Data.SqlClient;

namespace net_api.Resources;

public class Client : ResourceBase, IClient
{
    public Client(IConfiguration configuration) : base(configuration) { }

    public List<Models.Resource.Client> GetAllClients()
    {
        using IDbConnection db = new SqlConnection(ConnectionString);
        return db.Query<Models.Resource.Client>("select * from dbo.Clients").ToList();
    }
}

public interface IClient
{
    List<net_api.Models.Resource.Client> GetAllClients();
}