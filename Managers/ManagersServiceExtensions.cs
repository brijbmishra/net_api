namespace net_api.Managers;

public static class ManagersServiceExtensions {
    public static IServiceCollection AddManagers(this IServiceCollection services) {
        services.AddTransient<IClient, Client>();

        return services;
    }
}