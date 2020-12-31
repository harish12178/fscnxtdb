using System.ComponentModel.DataAnnotations;
using System;
namespace TruckTracking.API.Models
{
    public class m_device
    {
        [Key]
        public string DeviceID { get; set; }
        public string Name { get; set; }
        public string Purpose { get; set; }
        public DateTime PuttoUse { get; set; }
        public int Battery { get; set; }
        public int Healthy { get; set; }
        public string SoftwareVersion { get; set; }
        public float Vcc { get; set; }
        public int Lifespan { get; set; }
    }
}