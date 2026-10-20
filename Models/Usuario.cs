namespace BlazorUsersJsonPlaceHolderApi.Models
{
    public class Usuario
    {
        public string? Name { get; set; }
        public Endereco? Address { get; set; }
        public Empresa? Company { get; set; }
    }

    public class Endereco
    {
        public string? City { get; set; }
    }

    public class Empresa
    {
        public string? Name { get; set; }
    }
}