using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TruckTracking.API.Repositories;
namespace TruckTracking.API.Controllers
{
    [Route("transAPI/[controller]/[action]")]
    [ApiController]
    public class HeaderController:ControllerBase
    {
        private readonly ITransRepository repo;
        public HeaderController(ITransRepository repository)
        {
            this.repo=repository;
        }
         public async Task<IActionResult> GetAllHeaders(){
            return Ok(await this.repo.GetAllHeaders());
        }
        public async Task<IActionResult> GetHeader(int TransID){
            var header = await repo.GetHeader(TransID);

            if (header == null)
            {
                return NotFound($"Header with TransId = {TransID} not found");
            }

            return Ok(header);
        }
        
    }
}