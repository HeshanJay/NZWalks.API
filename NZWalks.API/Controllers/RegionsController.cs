using Microsoft.AspNetCore.Mvc;
using NZWalks.API.Models;

namespace NZWalks.API.Controllers
{
    //GET: https://localhost:portnumber/api/regions
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        //action method to get all regions 
        //GET ALL REGIONS 
        //GET: https://localhost:portnumber/api/regions
        [HttpGet]
        public IActionResult GetAll()
        {
            var regions = new List<Region>
            {
                new Region
                {
                    Id = Guid.NewGuid(),
                    Name = "Auckland Region",
                    Code = "AKL",
                    RegionImageUrl = "https://images.pexels.com/photos/20047948/pexels-photo-20047948/free-photo-of-black-and-white-view-of-a-modern-city.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2"
                },
                new Region
                {
                    Id = Guid.NewGuid(),
                    Name = "Wellington Region",
                    Code = "WLG",
                    RegionImageUrl = "https://images.pexels.com/photos/4350631/pexels-photo-4350631.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=2"
                }
            };

            return Ok(regions);
        }
    }
}
