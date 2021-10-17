namespace Pharmaceuticals.Models
{
    public class Laboratory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CNPJ { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Address { get; set; }
        public string Image { get; set; }
        public string Slug { get; set; }

    }
}

