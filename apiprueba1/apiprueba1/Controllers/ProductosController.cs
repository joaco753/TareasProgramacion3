using apiprueba1.Data;
using apiprueba1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace apiprueba1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {

        private readonly ApplicationDbContext _db;

        public ProductosController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<IActionResult> GetProductos()
        {
            var lista = await _db.Productos.OrderBy(c => c.Name).ToListAsync();

            return Ok(lista);
        }

        [HttpGet("{id:int}")]
        
        public async Task<IActionResult> GetProducto(int id)
        {
            var obj = await _db.Productos.FirstOrDefaultAsync(c => c.Id == id);

            if (obj == null)
            {
                return NotFound();
            }

            return Ok(obj);
        }

        [HttpPost]
        public async Task<IActionResult> CrearProducto([FromBody] Productos producto)
        {
            if (producto == null)
            {
                return BadRequest(ModelState);
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _db.Productos.AddAsync(producto);
            await _db.SaveChangesAsync();

            return Ok();
        }

    }
}
