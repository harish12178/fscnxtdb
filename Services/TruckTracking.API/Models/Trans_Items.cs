using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TruckTracking.API.Models
{
    public class Trans_Items
    {
        public int TransID { get; set; }
        public string RefDoc { get; set; }
        public string Item { get; set; }
        public string Material { get; set; }
        public string MaterialGroup { get; set; }
        public int Quantity { get; set; }
        public string uOM { get; set; }
        public int Value { get; set; }
        public string Currency { get; set; }
        [ForeignKey("TransID")]
        public Trans_Headers Headers { get; set; }
    }
}