﻿namespace Multi_Tenancy.settings
{
    public class Tenant
    {
        public string Name { get; set; } = null!;
        public string TId { get; set; } = null!;
        public string? ConnectionString { get; set; } = null!;

    }
}
