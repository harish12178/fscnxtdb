using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TruckTracking.API.Repositories;
namespace TruckTracking.API.Controllers
{
    [Route("transAPI/[controller]/[action]")]
    [ApiController]
    public class LocationController:ControllerBase
    {
        private readonly ITransRepository repo;
        public LocationController(ITransRepository repository)
        {
            this.repo=repository;
        }
        public async Task<IActionResult> GetAllLocations(){
            return Ok(await this.repo.GetAllLocations());
        }
        public async Task<IActionResult> GetLocation(int TransID){
            var location = await repo.GetLocation(TransID);

            if (location == null)
            {
                return NotFound($"Location with TransId = {TransID} not found");
            }

            return Ok(location);
        }

    }
    
}