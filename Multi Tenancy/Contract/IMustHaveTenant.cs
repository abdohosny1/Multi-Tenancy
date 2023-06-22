namespace Multi_Tenancy.Contract
{
    public interface IMustHaveTenant
    {
        public string? TenantId { get; set; } 
    }
}
