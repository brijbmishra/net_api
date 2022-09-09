namespace net_api.Resources;

public static class ResourcesServiceExtensions {
    public static IServiceCollection AddResources(this IServiceCollection services) {
        services.AddTransient<IClient, Client>();

        return services;
    }
}