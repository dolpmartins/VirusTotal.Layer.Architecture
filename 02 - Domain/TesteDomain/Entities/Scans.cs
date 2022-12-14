using Newtonsoft.Json;

namespace Teste.Domain.Entities
{
    public class Scans : BaseEntity
    {
        public NProtect nProtect { get; set; }

        [JsonProperty("CAT-QuickHeal")]
        public CATQuickHeal CATQuickHeal { get; set; }
        public McAfee McAfee { get; set; }
        public TheHacker TheHacker { get; set; }
        public VirusBuster VirusBuster { get; set; }
    }
}
