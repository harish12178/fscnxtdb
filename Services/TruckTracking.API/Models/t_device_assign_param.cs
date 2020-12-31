using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TruckTracking.API.Models
{
    public class t_device_assign_param
    {
        public string assignmentID { get; set; }
        public string PramID { get; set; }
        public string Title { get; set; }
        public string Unit { get; set; }
        public string longText { get; set; }
        public float Max { get; set; }
        public float Min { get; set; }
        public string Icon { get; set; }
        public float Soft_1_Exception_Threshold { get; set; }
        public float Soft_2_Exception_Threshold { get; set; }
        public float Hard_1_Exception_Threshold { get; set; }
        public float Hard_2_Exception_Threshold { get; set; }
        public string ActivityGraphTitle { get; set; }
        [ForeignKey("assignmentID")]
        public t_device_assign device_assign { get; set; }

    }
}