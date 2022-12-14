namespace Teste.Domain.Entities
{
    public class Scan : BaseEntity
    {
        public string scan_id { get; set; }
        public string sha1 { get; set; }
        public string resource { get; set; }
        public int response_code { get; set; }
        public string sha256 { get; set; }
        public string permalink { get; set; }
        public string md5 { get; set; }
        public string Verboverbose_msgseMsg { get; set; }
        public Report report { get; set; }
    }
}
