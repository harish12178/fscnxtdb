using Microsoft.EntityFrameworkCore;
namespace TruckTracking.API.Models
{
    public class TransportContext:DbContext
    {
        public TransportContext(DbContextOptions<TransportContext> options): base(options)
        {

        }
    
        public DbSet<Trans_Headers> Trans_H {get;set;}
        public DbSet<Trans_Items> Trans_I { get; set; }
        public DbSet<Trans_Location> Trans_Loc { get; set; }
        // public DbSet <Device_log> Device_log { get; set; }
        // public DbSet <m_device> m_device { get; set; }
        // public DbSet <m_device_param> m_device_param { get; set; }
        // public DbSet <m_equipment> m_equipment { get; set; }
        // public DbSet <m_Loc> m_Loc { get; set; }
        // public DbSet <m_TrkDo> m_TrkDo { get; set; }
        // public DbSet <t_device_assign> t_device_assign { get; set; }
        // public DbSet <t_device_assign_param> t_device_assign_param { get; set; }
        // public DbSet <t_trkdo_assign> t_trkdo_assign { get; set; }
        // public DbSet <t_TrkDoLog> t_TrkDoLog { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Trans_Headers>().HasKey(s => new { s.TransID, s.TransporterID,s.PartnerID }); 
             modelBuilder.Entity<Trans_Items>().HasKey(s => new { s.TransID,s.RefDoc });
             modelBuilder.Entity<Trans_Location>().HasKey(s => new {  s.TransID ,s.SINo});
            //  modelBuilder.Entity<m_device_param>().HasKey(s=>new {s.DeviceID,s.ParamID});
            //   modelBuilder.Entity<t_device_assign_param>().HasKey(s=>new {s.PramID,s.assignmentID});
        }
    }
    
}