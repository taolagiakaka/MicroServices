using Microsoft.AspNetCore.Mvc;

namespace CommandsService.Controllers
{
    [Route("api/c/[controller]")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        public CommandsController()
        {

        }

        [HttpPost]
        public ActionResult TestInBoundConnection()
        {
            System.Console.WriteLine("--> InBound Connection # Command service");

            return Ok();
        }
    }
}