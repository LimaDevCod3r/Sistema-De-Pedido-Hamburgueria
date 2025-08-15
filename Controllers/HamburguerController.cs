

using Microsoft.AspNetCore.Mvc;
using SistemaDePedidoHamburgueria.Context;
using SistemaDePedidoHamburgueria.Models;

namespace SistemaDePedidoHamburgueria.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HamburguerController : ControllerBase
    {
        private readonly HamburgueriaApiDBContext _context;

        public HamburguerController(HamburgueriaApiDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Hamburger>> findAll()
        {
            var hambúrgueres = _context.Hamburgers.ToList();

            if (hambúrgueres is null)
            {
                return NotFound();
            }

            return hambúrgueres;
        }

    }
}