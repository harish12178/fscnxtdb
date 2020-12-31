using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
namespace TruckTracking.API.Models
{
    public class Trans_Location
    {
        public int TransID { get; set; }
        public int SINo { get; set; }
        public DateTime DateTime { get; set; }
        public string GeoLoc { get; set; }
        [ForeignKey("TransID")]
        public Trans_Headers Headers { get; set; }
    }
}