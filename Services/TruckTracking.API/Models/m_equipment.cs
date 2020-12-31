using System.ComponentModel.DataAnnotations;
namespace TruckTracking.API.Models
{
    public class m_equipment
    {
        [Key]
        public string EquipmentID { get; set; }
        public string Text { get; set; }
        public string GeoLoc { get; set; }
        public string Plant { get; set; }
        public string Workcenter { get; set; }
    }
}