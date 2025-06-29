using Microsoft.AspNetCore.Mvc;
using ToolTrack.API.Models;
using ToolTrack.API.Services;

namespace ToolTrack.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HerramientasController : ControllerBase
    {
        private readonly HerramientaService _herramientaService;

        public HerramientasController(HerramientaService herramientaService)
        {
            _herramientaService = herramientaService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Herramienta>>> Get() =>
            await _herramientaService.GetAsync();

        [HttpGet("{id:length(24)}")]
        public async Task<ActionResult<Herramienta>> Get(string id)
        {
            var herramienta = await _herramientaService.GetByIdAsync(id);

            if (herramienta is null)
                return NotFound();

            return herramienta;
        }

        [HttpPost]
        public async Task<IActionResult> Post(Herramienta herramienta)
        {
            await _herramientaService.CreateAsync(herramienta);
            return CreatedAtAction(nameof(Get), new { id = herramienta.Id }, herramienta);
        }

        [HttpPut("{id:length(24)}")]
        public async Task<IActionResult> Update(string id, Herramienta herramientaIn)
        {
            var herramienta = await _herramientaService.GetByIdAsync(id);

            if (herramienta is null)
                return NotFound();

            herramientaIn.Id = id;
            await _herramientaService.UpdateAsync(id, herramientaIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public async Task<IActionResult> Delete(string id)
        {
            var herramienta = await _herramientaService.GetByIdAsync(id);

            if (herramienta is null)
                return NotFound();

            await _herramientaService.DeleteAsync(id);
            return NoContent();
        }
    }
}
