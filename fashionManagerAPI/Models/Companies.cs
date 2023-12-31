﻿namespace fashionManager.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Cnpj { get; set; }
        public string Manager { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public ICollection<CompanySetup> CompaniesSetups { get; set; }
        public ICollection<Collection> Collections { get; set; }
        public List<User> Users { get; set; }
    }
}
