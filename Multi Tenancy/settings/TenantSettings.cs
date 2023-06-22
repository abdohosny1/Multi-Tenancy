namespace Multi_Tenancy.settings
{
    public class TenantSettings
    {
        public Configuration Defuls { get; set; } = default!;
        public List<Tenant> Tenants { get; set; }=new ();
    }
}
