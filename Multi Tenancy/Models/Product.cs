
namespace Multi_Tenancy.Models
{
    public class Product: IMustHaveTenant
    {
        public int Id { get; set; }
        public int Rate { get; set; }
        public string Name { get; set; } = null!;
        public string  Descripation { get; set; }=null!;
        public string? TenantId { get; set; } = null!;
    }
}
