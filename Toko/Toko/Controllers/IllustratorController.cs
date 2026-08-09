using Microsoft.AspNetCore.Mvc;
using Toko.EFCore.Application.Models;
using Toko.EFCore.Application.Services;

namespace Toko.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IllustratorController : ControllerBase
    {
        private readonly IIllustratorService _illustratorService;

        public IllustratorController(IIllustratorService illustratorService)
        {
            _illustratorService = illustratorService;
        }

        [HttpPost]
        public async Task<IActionResult> InsertAsync([FromBody] InsertUpdateIllustrator insertIllustrator)
        {
            if (insertIllustrator == null)
            {
                return BadRequest("Invalid illustrator data.");
            }
            var illustratorId = await _illustratorService.InsertAsync(insertIllustrator);
            return CreatedAtAction(nameof(InsertAsync), new { id = illustratorId }, insertIllustrator);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(int id, [FromBody] InsertUpdateIllustrator updateIllustrator)
        {
            if (updateIllustrator == null)
            {
                return BadRequest("Invalid illustrator data.");
            }
            var illustratorId = await _illustratorService.UpdateAsync(id, updateIllustrator);
            return Ok();
        }
    }
}
