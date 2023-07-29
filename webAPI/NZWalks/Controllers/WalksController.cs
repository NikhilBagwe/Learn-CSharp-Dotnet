using Microsoft.AspNetCore.Mvc;
using NZWalks.Data;
using NZWalks.Models.Domain;
using NZWalks.Models.DTO;

namespace NZWalks.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WalksController : ControllerBase
    {
        private readonly NZWalksDbContext _dbContext;
        public WalksController(NZWalksDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("GetAllWalks")]
        public IActionResult GetAllWalks()
        {
            // Walks Domain model
            var walks = _dbContext.Walks.ToList();

            var walksDTO = new List<WalksDTO>();
            foreach (var walk in walks)
            {
                walksDTO.Add(new WalksDTO()
                {
                    Id = walk.Id,
                    Name = walk.Name,
                    Description = walk.Description,
                    LengthInKm = walk.LengthInKm,
                    WalkImageUrl = walk.WalkImageUrl
                });
            }

            return Ok(walksDTO);
        }

        [HttpGet("GetWalkById")]
        public IActionResult GetWalkById(Guid id)
        {
            var walk = _dbContext.Walks.Find(id);

            if (walk == null) return NotFound();

            var walkDTO = new WalksDTO
            {
                Id = walk.Id,
                Name = walk.Name,
                Description = walk.Description,
                LengthInKm = walk.LengthInKm,
                WalkImageUrl = walk.WalkImageUrl
            };

            return Ok(walkDTO);
        }

        [HttpPost("AddWalk")]
        public IActionResult AddWalk(AddWalkRequestDTO addWalkRequestDTO)
        {
            var walkDomainModel = new Walk
            {
                Name = addWalkRequestDTO.Name,
                Description = addWalkRequestDTO.Description,
                LengthInKm = addWalkRequestDTO.LengthInKm,
                WalkImageUrl = addWalkRequestDTO.WalkImageUrl,
                DifficultyId = addWalkRequestDTO.DifficultyId,
                RegionId = addWalkRequestDTO.RegionId
            };

            _dbContext.Walks.Add(walkDomainModel);
            _dbContext.SaveChanges();

            var walkDTO = new WalksDTO
            {
                Id = walkDomainModel.Id,
                Name = walkDomainModel.Name,
                Description = walkDomainModel.Description,
                LengthInKm = walkDomainModel.LengthInKm,
                WalkImageUrl = walkDomainModel.WalkImageUrl
            };

            return Ok(walkDTO);
        }

        [HttpDelete("DeleteWalk")]
        public IActionResult DeleteWalk(Guid id)
        {
            var walk = _dbContext.Walks.Find(id);

            if (walk == null) return NotFound();

            _dbContext.Walks.Remove(walk);
            _dbContext.SaveChanges();
            return NoContent();
        }

        [HttpPatch("UpdateWalk")]
        public IActionResult UpdateWalk(WalksDTO walksDTO)
        {
            // walk domain model
            var walk = _dbContext.Walks.Find(walksDTO.Id);

            if (walk == null) return NotFound();

            walk.Name = walksDTO.Name;
            walk.Description = walksDTO.Description;
            walk.LengthInKm = walksDTO.LengthInKm;
            walk.WalkImageUrl = walksDTO.WalkImageUrl;

            _dbContext.SaveChanges();
            return NoContent();
        }
    }
}