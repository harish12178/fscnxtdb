using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TruckTracking.API.Models
{
    public class t_TrkDoLog
    {
        [Key]
        public int LogID { get; set; }
        public string TrkDoID { get; set; }
        public string DeviceID { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Direction { get; set; }
        [ForeignKey("TrkDoID")]
        public m_TrkDo TrkDo { get; set; }
        [ForeignKey("DeviceID")]
        public m_device device { get; set; }
    }
}