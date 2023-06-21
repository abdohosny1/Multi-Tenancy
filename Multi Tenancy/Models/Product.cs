namespace Multi_Tenancy.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int Rate { get; set; }
        public string Name { get; set; } = null!;
        public string  Descripation { get; set; }=null!;
    }
}
