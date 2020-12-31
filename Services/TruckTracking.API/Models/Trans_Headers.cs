using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
namespace TruckTracking.API.Models
{
    public class Trans_Headers
    {
        [Key]
        // [ForeignKey("Items")]
        public int TransID { get; set; }
        public string Type { get; set; }
        public string TransporterID { get; set; }
        public string PartnerID { get; set; }
        public DateTime RecordDate { get; set; }
        public string OTP { get; set; }
        public string FromAddress { get; set; }
        public string ToAddress { get; set; }
        public string FromPlant { get; set; }
        public string ToPlant { get; set; }
        public string MaterialGroup { get; set; }
        public string Truck { get; set; }
        public string Driver { get; set; }
        public string Helper { get; set; }
        public string TruckType { get; set; }
        public string ContactNumber1 { get; set; }
        public string ContactNumber2 { get; set; }
        public DateTime TripStartDate { get; set; }
        public string TripStartLoc { get; set; }
        public string DeviceID { get; set; }
        public DateTime LastReportedDateTime { get; set; }
        public string LastReportedLocation { get; set; }
        public DateTime TripEndDate { get; set; }
        public string TripEndLoc { get; set; }
        public string isExceptionOccured { get; set; }
        public string PoDRefDoc { get; set; }
        public string Status { get; set; }
        [ForeignKey("DeviceID")]
        public m_device device { get; set; }

    }
}