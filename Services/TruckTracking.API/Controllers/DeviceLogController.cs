using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TruckTracking.API.Repositories;
using TruckTracking.API.Models;
namespace TruckTracking.API.Controllers
{
    [Route("transAPI/[controller]/[action]")]
    [ApiController]
    public class DeviceLogController:ControllerBase
    {
        private readonly ITransRepository repo;
        public DeviceLogController(ITransRepository repository)
        {
            this.repo=repository;
        }
    //     public async Task<IActionResult> GetAllLogs(){
    //         return Ok(await this.repo.GetAllLogs());
    //     }
    //     public async Task<IActionResult> GetLog(string deviceID){
    //         var log = await repo.GetLog(deviceID);

    //         if (log == null)
    //         {
    //             return NotFound($"Log with deviceID = {deviceID} not found");
    //         }

    //         return Ok(log);
    //     }

    //     public async Task<IActionResult> Log(Device_log log)
    //     {
    //         var created_log=await repo.CreateLog(log);
    //         return CreatedAtAction(nameof(GetLog),new {id = created_log.LogID}, created_log);
    //     }
        
    }
}