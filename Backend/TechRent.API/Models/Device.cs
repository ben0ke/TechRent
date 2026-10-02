namespace TechRent.API.Models
{
    public class Device
    {
        public int Id { get; set; }
        public string Megnevezes { get; set; } = string.Empty;
        public string Kategoria { get; set; } = string.Empty;
        public string Allapot { get; set; } = string.Empty;
    }
}