using Multi_Tenancy.settings;

namespace Multi_Tenancy.services
{
    public interface ITenanetServices
    {
        string? GetDatabaseProvider();
        string? GetConnectionString();
        Tenant? GetCurrentTenant();
    }
}
