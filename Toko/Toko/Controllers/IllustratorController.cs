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
        public async Task<IActionResult> InsertIllustratorAsync([FromBody] InsertUpdateIllustrator insertIllustrator)
        {
            if (insertIllustrator == null)
            {
                return BadRequest("Invalid illustrator data.");
            }
            var illustratorId = await _illustratorService.InsertAsync(insertIllustrator);
            return CreatedAtAction(nameof(InsertIllustratorAsync), new { id = illustratorId }, insertIllustrator);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateIllustratorAsync(int id, [FromBody] InsertUpdateIllustrator updateIllustrator)
        {
            if (updateIllustrator == null)
            {
                return BadRequest("Invalid illustrator data.");
            }
            var illustratorId = await _illustratorService.UpdateAsync(id, updateIllustrator);
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetIllustratorById(int id)
        {
            // Implement the logic to retrieve the illustrator by ID
            // For now, return a placeholder response
            return Ok(new { Id = id, Name = "Placeholder Name", Socials = "Placeholder Socials", NSFW = false });
        }
    }
}
