using System.ComponentModel.DataAnnotations.Schema;

namespace Teste.Domain.Entities
{
    public class Report : BaseEntity
    {
        public int response_code { get; set; }
        public string verbose_msg { get; set; }
        public string resource { get; set; }
        
        public string scan_id { get; set; }
        public string md5 { get; set; }
        public string sha1 { get; set; }
        public string sha256 { get; set; }
        public string scan_date { get; set; }
        public string permalink { get; set; }
        public int positives { get; set; }
        public int total { get; set; }
        public Scans scans { get; set; }

        public Scan scan { get; set; }
    }
}
