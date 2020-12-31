using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TruckTracking.API.Repositories;
using TruckTracking.API.Models;
namespace TruckTracking.API.Controllers
{
    [Route("transAPI/[controller]/[action]")]
    [ApiController]
    public class MasterController:ControllerBase
    {
        private readonly ITransRepository repo;
        public MasterController(ITransRepository repository)
        {
            this.repo=repository;
        }
        // public async Task<IActionResult> GetAllDevices(){
        //     return Ok(await this.repo.GetAllDevices());
        // }
        // public async Task<IActionResult> GetAllDeviceParams(){
        //     return Ok(await this.repo.GetAllDeviceParams());
        // }
        // public async Task<IActionResult> GetAllEquipments(){
        //     return Ok(await this.repo.GetAllEquipments());
        // }
        // public async Task<IActionResult> GetAllLocs(){
        //     return Ok(await this.repo.GetAllLocs());
        // }
        // public async Task<IActionResult> GetAllTrkDos(){
        //     return Ok(await this.repo.GetAllTrkDos());
        // }
        // public async Task<IActionResult> device(m_device device)
        // {
        //     var created=await repo.CreateDevice(device);
        //     return Ok(created);
        // }
        // public async Task<IActionResult> deviceparam(m_device_param device)
        // {
        //     var created=await repo.CreateDeviceParam(device);
        //     return Ok(created);
        // }
        // public async Task<IActionResult> equipment(m_equipment device)
        // {
        //     var created=await repo.CreateEquipment(device);
        //     return Ok(created);
        // }
        // public async Task<IActionResult> location(m_Loc device)
        // {
        //     var created=await repo.CreateLoc(device);
        //     return Ok(created);
        // }
        // public async Task<IActionResult> trkdo(m_TrkDo device)
        // {
        //     var created=await repo.CreateTrkdo(device);
        //     return Ok(created);
        // }
        // public async Task<IActionResult> deletedevice(string id){
        //     await repo.DeleteDevice(id);
        //     return Ok();

        // }
        // public async Task<IActionResult> deletedeviceparam(string id){
        //     await repo.DeleteDeviceparam(id);
        //     return Ok();

        // }
        // public async Task<IActionResult> deleteequipment(string id){
        //     await repo.DeleteEquipment(id);
        //     return Ok();
        // }
        // public async Task<IActionResult> deletelocation(string id){
        //     await repo.DeleteLoc(id);
        //     return Ok();
        // }
        // public async Task<IActionResult> deletetrkdo(string id){
        //     await repo.DeleteTrkdo(id);
        //     return Ok();
        // }
        
    }
}