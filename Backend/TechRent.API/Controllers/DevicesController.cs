using Microsoft.AspNetCore.Mvc;
using TechRent.API.Models;

namespace TechRent.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DevicesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Device>> GetDevices()
        {
            // Teszt adatok, amíg a MySQL kapcsolat nem készül el
            var devices = new List<Device>
            {
                new Device { Id = 1, Megnevezes = "MacBook Pro 14", Kategoria = "Laptop", Allapot = "Elérhető" },
                new Device { Id = 2, Megnevezes = "Lenovo ThinkPad", Kategoria = "Laptop", Allapot = "Kölcsönözve" }
            };

            return Ok(devices);
        }
    }
}