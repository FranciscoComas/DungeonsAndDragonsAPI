using DungeonsAndDragons.Razas.Draconidos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace DungeonsAndDragons.Controllers.RazasJugables.Draconidos
{
    [ApiController]
    [Route("[controller]")]
    public class SangreDragonController : ControllerBase
    {
        private readonly ILogger<SangreDragonController> _logger;

        public SangreDragonController(ILogger<SangreDragonController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetSangreDragonBase")]
        public string GetSangreDragonBase()
        {
            SangreDragon sangreDragon = new SangreDragon();
            string sangreDragonstring = JsonConvert.SerializeObject(sangreDragon, Formatting.Indented);
            return sangreDragonstring;
        }
    }
}
