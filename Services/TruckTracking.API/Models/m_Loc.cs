using System.ComponentModel.DataAnnotations;
namespace TruckTracking.API.Models
{
    public class m_Loc
    {
        [Key]
        public string LocationID { get; set; }
        public string LcoationText { get; set; }
        public string WorkCenter { get; set; }
        public string Plant { get; set; }
        public string Geo { get; set; }
        public string ParantLocationID { get; set; }
    }
}