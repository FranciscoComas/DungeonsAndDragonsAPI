using DungeonsAndDragons.Razas;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;

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

        [HttpGet]
        public string GetSangreDragonBase()
        {
            RazaJugable sangreDragon = new RazaJugable();
            string sangreDragonstring = JsonConvert.SerializeObject(sangreDragon, Formatting.Indented);
            return sangreDragonstring;
        }
    }
}
