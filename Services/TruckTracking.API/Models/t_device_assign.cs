using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TruckTracking.API.Models
{
    public class t_device_assign
    {
        [Key]
        public string assignmentID { get; set; }
        public string DeviceID { get; set; }
        public string EquipmentID { get; set; }
        public DateTime StDateTime { get; set; }
        public DateTime enDateTime { get; set; }
        public int Frequency { get; set; }
        public int LocID { get; set; }
        [ForeignKey("DeviceID")]
        public m_device device { get; set; }
        [ForeignKey("EquipmentID")]
        public m_equipment equipment { get; set; }
    }
}