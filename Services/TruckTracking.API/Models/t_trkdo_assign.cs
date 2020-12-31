using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TruckTracking.API.Models
{
    public class t_trkdo_assign
    {
        [Key]
        public int TransID { get; set; }
        public string TrkDoID { get; set; }
        public string Object { get; set; }
        public int ObjectNumber { get; set; }
        public DateTime AssingedOn { get; set; }
        public DateTime RemovedOn { get; set; }
        public bool isOpen { get; set; }
        [ForeignKey("TrkDoID")]
        public m_TrkDo TrkDo { get; set; }
    }
}