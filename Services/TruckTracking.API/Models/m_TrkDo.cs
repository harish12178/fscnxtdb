using System.ComponentModel.DataAnnotations;
namespace TruckTracking.API.Models
{
    public class m_TrkDo
    {
        [Key]
        public string TrkDoID { get; set; }
        public string Type { get; set; }
        public string UniqueID { get; set; }
        public string LifeStatus { get; set; }
        public string isAssinged { get; set; }
    }
}