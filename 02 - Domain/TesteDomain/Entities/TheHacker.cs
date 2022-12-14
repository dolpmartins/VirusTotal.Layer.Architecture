namespace Teste.Domain.Entities
{
    public class TheHacker : BaseEntity
    {
        public bool detected { get; set; }
        public string version { get; set; }
        public string result { get; set; }
        public string update { get; set; }
    }
}
