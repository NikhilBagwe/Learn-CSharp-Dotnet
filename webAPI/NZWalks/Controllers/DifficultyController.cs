using Microsoft.AspNetCore.Mvc;
using NZWalks.Data;
using NZWalks.Models.Domain;
using NZWalks.Models.DTO;

namespace NZWalks.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DifficultyController : ControllerBase
    {
        private readonly NZWalksDbContext _dbContext;
        public DifficultyController(NZWalksDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("GetAllDifficulties")]
        public IActionResult GetAllDifficulties()
        {
            var difficulties = _dbContext.Difficulties.ToList();

            // We can convert "difficulties" domain model to DTO but since there are only 2 properties we skip it here.

            return Ok(difficulties);
        }

        [HttpGet("GetDifficultyById")]
        public IActionResult GetDifficultyById(Guid id)
        {
            var difficulty = _dbContext.Difficulties.Find(id);

            if (difficulty == null) return NotFound();

            return Ok(difficulty);
        }

        [HttpPost("AddDifficulty")]
        public IActionResult AddDifficulty(AddDifficultyRequestDTO addDifficultyRequestDTO)
        {
            var difficultyDomainModel = new Difficulty
            {
                Name = addDifficultyRequestDTO.Name
            };

            _dbContext.Difficulties.Add(difficultyDomainModel);
            _dbContext.SaveChanges();

            var difficultyDTO = new Difficulty
            {
                Id = difficultyDomainModel.Id,
                Name = difficultyDomainModel.Name
            };

            return Ok(difficultyDTO);
        }

        [HttpDelete("DeleteDifficulty")]
        public IActionResult DeleteDifficulty(Guid id)
        {
            var diffDomainModel = _dbContext.Difficulties.Find(id);

            if (diffDomainModel == null) return NotFound();

            _dbContext.Difficulties.Remove(diffDomainModel);
            _dbContext.SaveChanges();
            return NoContent();
        }

        [HttpPatch("UpdateDifficulty")]
        public IActionResult UpdateDifficulty(Difficulty difficulty)
        {
            var diffDomainModel = _dbContext.Difficulties.Find(difficulty.Id);
            if (diffDomainModel == null) return NotFound();

            diffDomainModel.Name = difficulty.Name;

            _dbContext.SaveChanges();
            return NoContent();
        }
    }
}