using TruckTracking.API.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using System.Linq;
namespace TruckTracking.API.Repositories
{
    public class TransRepository:ITransRepository
    {
        private readonly TransportContext _context;

        public TransRepository(TransportContext context)
        {
            _context = context;
        }
        public async Task<List<Trans_Headers>> GetAllHeaders(){
            return await _context.Trans_H.ToListAsync();
        }
        public async Task<List<Trans_Items>> GetAllItems(){
            return await _context.Trans_I.ToListAsync();
        }
        public async Task<List<Trans_Location>> GetAllLocations(){
            return await _context.Trans_Loc.ToListAsync();
        }
        // public async Task<List<Device_log>> GetAllLogs(){
        //     return await _context.Device_log.ToListAsync();
        // }
        public async Task<Trans_Headers> GetHeader(int id){
            return await _context.Trans_H.FirstOrDefaultAsync(data=>data.TransID==id);
        }
        public async Task<Trans_Items> GetItem(int id){
            return await _context.Trans_I.FirstOrDefaultAsync(data=>data.TransID==id);
        }
        public async Task<Trans_Location> GetLocation(int id){
            return await _context.Trans_Loc.FirstOrDefaultAsync(data=>data.TransID==id);
        }
        // public async Task<Device_log> GetLog(string id){
        //     return await _context.Device_log.OrderByDescending(e=>e.LogID).FirstOrDefaultAsync(data=>data.DeviceID==id);
        // }
        // public async Task<Device_log> CreateLog(Device_log log){
        //     // var result = await _context.Device_log.FirstOrDefaultAsync(e => e.DeviceID == log.DeviceID);
        //     // if (result != null)
        //     // {
        //     //     result.DeviceID=log.DeviceID;
        //     //     result.RefID = log.RefID;
        //     //     result.PramID = log.PramID;
        //     //     result.value=log.value;
        //     //     result.avgValue=log.avgValue;
        //     //     result.dateTime=DateTime.Now;
        //     //     await _context.SaveChangesAsync();
        //     //     return result;
        //     // } 
        //     // else{
        //         log.dateTime=DateTime.Now;
        //         var new_log=await _context.Device_log.AddAsync(log);
        //         await _context.SaveChangesAsync();
        //         return new_log.Entity;
        //     // }
        // }
        // public async Task<m_device> CreateDevice(m_device device){
        //     var result = await _context.m_device.FirstOrDefaultAsync(e => e.DeviceID == device.DeviceID);
        //     if (result != null)
        //     {
        //         result.DeviceID = device.DeviceID;
        //         result.Name = device.Name;
        //         result.Purpose = device.Purpose;
        //         result.PuttoUse=device.PuttoUse;
        //         result.Battery=device.Battery;
        //         result.Healthy=device.Healthy;
        //         result.SoftwareVersion=device.SoftwareVersion;
        //         result.Vcc=device.Vcc;
        //         result.Lifespan=device.Lifespan;
        //         await _context.SaveChangesAsync();
        //         return result;
        //     } 
        //     else{
        //         var new_log=await _context.m_device.AddAsync(device);
        //         await _context.SaveChangesAsync();
        //         return new_log.Entity;
        //     }
        // }
        // public async Task<m_device_param> CreateDeviceParam(m_device_param device){
        //     var result = await _context.m_device_param.FirstOrDefaultAsync(e => e.ParamID == device.ParamID);
        //     if (result != null)
        //     {
        //         result.DeviceID = device.DeviceID;
        //         result.ParamID = device.ParamID;
        //         result.Title = device.Title;
        //         result.Unit=device.Unit;
        //         result.longText=device.longText;
        //         result.Max=device.Max;
        //         result.Min=device.Min;
        //         result.Icon=device.Icon;
        //         result.isPercentage=device.isPercentage;
        //         result.Color=device.Color;
        //         await _context.SaveChangesAsync();
        //         return result;
        //     } 
        //     else{
        //         var new_log=await _context.m_device_param.AddAsync(device);
        //         await _context.SaveChangesAsync();
        //         return new_log.Entity;
        //     }
        // }
        // public async Task<m_equipment> CreateEquipment(m_equipment device){
        //     var result = await _context.m_equipment.FirstOrDefaultAsync(e => e.EquipmentID == device.EquipmentID);
        //     if (result != null)
        //     {
        //         result.EquipmentID = device.EquipmentID;
        //         result.Text = device.Text;
        //         result.GeoLoc = device.GeoLoc;
        //         result.Plant=device.Plant;
        //         result.Workcenter=device.Workcenter;
        //         await _context.SaveChangesAsync();
        //         return result;
        //     } 
        //     else{
        //         var new_log=await _context.m_equipment.AddAsync(device);
        //         await _context.SaveChangesAsync();
        //         return new_log.Entity;
        //     }
        // }
        // public async Task<m_Loc> CreateLoc(m_Loc device){
        //     var result = await _context.m_Loc.FirstOrDefaultAsync(e => e.LocationID == device.LocationID);
        //     if (result != null)
        //     {
        //         result.LocationID = device.LocationID;
        //         result.LcoationText = device.LcoationText;
        //         result.WorkCenter = device.WorkCenter;
        //         result.Plant=device.Plant;
        //         result.Geo=device.Geo;
        //         result.ParantLocationID=device.ParantLocationID;
        //         await _context.SaveChangesAsync();
        //         return result;
        //     } 
        //     else{
        //         var new_log=await _context.m_Loc.AddAsync(device);
        //         await _context.SaveChangesAsync();
        //         return new_log.Entity;
        //     }
        // }

        // public async Task<m_TrkDo> CreateTrkdo(m_TrkDo device){
        //     var result = await _context.m_TrkDo.FirstOrDefaultAsync(e => e.TrkDoID == device.TrkDoID);
        //     if (result != null)
        //     {
        //         result.TrkDoID = device.TrkDoID;
        //         result.Type = device.Type;
        //         result.UniqueID = device.UniqueID;
        //         result.LifeStatus=device.LifeStatus;
        //         result.isAssinged=device.isAssinged;
        //         await _context.SaveChangesAsync();
        //         return result;
        //     } 
        //     else{
        //         var new_log=await _context.m_TrkDo.AddAsync(device);
        //         await _context.SaveChangesAsync();
        //         return new_log.Entity;
        //     }
        // }

        // public async Task<List<m_device>> GetAllDevices(){
        //     return await _context.m_device.ToListAsync();
        // }
        // public async Task<List<m_device_param>> GetAllDeviceParams(){
        //     return await _context.m_device_param.ToListAsync();
        // }
        // public async Task<List<m_equipment>> GetAllEquipments(){
        //     return await _context.m_equipment.ToListAsync();
        // }
        // public async Task<List<m_Loc>> GetAllLocs(){
        //     return await _context.m_Loc.ToListAsync();
        // }
        // public async Task<List<m_TrkDo>> GetAllTrkDos(){
        //     return await _context.m_TrkDo.ToListAsync();
        // }
        // public async Task DeleteDevice(string Id){
        //     var result = await _context.m_device.FirstOrDefaultAsync(device => device.DeviceID == Id);
        //     if (result != null)
        //     {
        //         _context.m_device.Remove(result);
        //         await _context.SaveChangesAsync();
        //     }
        // }
        // public async Task DeleteDeviceparam(string Id){
        //     var result = await _context.m_device_param.FirstOrDefaultAsync(device => device.ParamID == Id);
        //     if (result != null)
        //     {
        //         _context.m_device_param.Remove(result);
        //         await _context.SaveChangesAsync();
        //     }
        // }
        // public async Task DeleteEquipment(string Id){
        //     var result = await _context.m_equipment.FirstOrDefaultAsync(device => device.EquipmentID == Id);
        //     if (result != null)
        //     {
        //         _context.m_equipment.Remove(result);
        //         await _context.SaveChangesAsync();
        //     }
        // }
        // public async Task DeleteLoc(string Id){
        //     var result = await _context.m_Loc.FirstOrDefaultAsync(device => device.LocationID == Id);
        //     if (result != null)
        //     {
        //         _context.m_Loc.Remove(result);
        //         await _context.SaveChangesAsync();
        //     }
        // }
        // public async Task DeleteTrkdo(string Id){
        //     var result = await _context.m_TrkDo.FirstOrDefaultAsync(device => device.TrkDoID == Id);
        //     if (result != null)
        //     {
        //         _context.m_TrkDo.Remove(result);
        //         await _context.SaveChangesAsync();
        //     }
        // }
    }
}