namespace Scisense.Models
{
    public class Contato
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string ContactNum { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        
        public string Readed { get; set; }
    }
}