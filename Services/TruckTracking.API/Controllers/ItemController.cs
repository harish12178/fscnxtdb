using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TruckTracking.API.Repositories;
namespace TruckTracking.API.Controllers
{
    [Route("transAPI/[controller]/[action]")]
    [ApiController]
    public class ItemController:ControllerBase
    {
        private readonly ITransRepository repo;
        public ItemController(ITransRepository repository)
        {
            this.repo=repository;
        }
        public async Task<IActionResult> GetAllItems(){
            return Ok(await this.repo.GetAllItems());
        }
        public async Task<IActionResult> GetItem(int TransID){
            var item = await repo.GetItem(TransID);

            if (item == null)
            {
                return NotFound($"Item with TransId = {TransID} not found");
            }

            return Ok(item);
        }
       
    }
}