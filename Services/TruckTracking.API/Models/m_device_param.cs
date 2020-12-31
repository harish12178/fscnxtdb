using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TruckTracking.API.Models
{
    public class m_device_param
    {
        public string DeviceID { get; set; }
        public string ParamID { get; set; }
        public string Title { get; set; }
        public string Unit { get; set; }
        public string longText { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
        public string Icon { get; set; }
        public string isPercentage { get; set; }
        public string Color { get; set; }
        [ForeignKey("DeviceID")]
        public m_device device { get; set; }
    }
}