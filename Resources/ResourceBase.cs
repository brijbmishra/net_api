public class ResourceBase
{
    private readonly IConfiguration _configuration;
    public ResourceBase(IConfiguration configuration)
    {
        _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
    }

    protected string ConnectionString => _configuration.GetConnectionString("Default");
}
