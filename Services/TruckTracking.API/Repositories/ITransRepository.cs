using TruckTracking.API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
namespace TruckTracking.API.Repositories
{
    public interface ITransRepository
    {
            Task<List<Trans_Headers>> GetAllHeaders();
            Task<Trans_Headers> GetHeader(int trans_id);
           
            Task<List<Trans_Items>> GetAllItems();
            Task<Trans_Items> GetItem(int trans_id);
            
            Task<List<Trans_Location>> GetAllLocations();
            Task<Trans_Location> GetLocation(int trans_id);

            // Task<List<Device_log>> GetAllLogs();
            // Task<Device_log> GetLog(string DeviceID);
            // Task<Device_log> CreateLog(Device_log log);
            
            // Task<List<m_device>> GetAllDevices();
            // Task<List<m_device_param>> GetAllDeviceParams();
            // Task<List<m_equipment>> GetAllEquipments();
            // Task<List<m_Loc>> GetAllLocs();
            // Task<List<m_TrkDo>> GetAllTrkDos();

            // Task DeleteDevice(string id);
            // Task<m_device> CreateDevice(m_device device);
            // Task DeleteDeviceparam(string id);
            // Task<m_device_param> CreateDeviceParam(m_device_param device);
            // Task DeleteEquipment(string id);
            // Task<m_equipment> CreateEquipment(m_equipment device);
            // Task DeleteLoc(string id);
            // Task<m_Loc> CreateLoc(m_Loc m_Loc);
            // Task DeleteTrkdo(string id);
            // Task<m_TrkDo> CreateTrkdo(m_TrkDo device);

    }
}