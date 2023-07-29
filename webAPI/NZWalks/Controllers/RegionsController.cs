using Microsoft.AspNetCore.Mvc;
using NZWalks.Data;
using NZWalks.Models.Domain;
using NZWalks.Models.DTO;

namespace NZWalks.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RegionsController : ControllerBase
    {
        // Since we injected DbContext using DI into our app, we can now use that Dbcontext inside our controller using Constructor injection.
        private readonly NZWalksDbContext _dbContext;
        public RegionsController(NZWalksDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            // var regions = new List<Region>
            // {
            //     new Region
            //     {
            //         Id = Guid.NewGuid(),
            //         Name = "Auckland Region",
            //         Code = "AKL",
            //         RegionImageUrl = "some url"
            //     },
            //     new Region
            //     {
            //         Id = Guid.NewGuid(),
            //         Name = "Welligton Region",
            //         Code = "WLG",
            //         RegionImageUrl = "some url"
            //     }
            // };

            // Get Data from DB - Domain Models
            var regions = _dbContext.Regions.ToList();

            // Map Domain Models to DTOs
            var regionsDto = new List<RegionDTO>();
            foreach (var region in regions)
            {
                regionsDto.Add(new RegionDTO()
                {
                    Id = region.Id,
                    Code = region.Code,
                    Name = region.Name,
                    RegionImageUrl = region.RegionImageUrl
                });
            }

            // Return DTOs
            return Ok(regionsDto);
        }

        // Get Region by Id
        [HttpGet]
        [Route("{id:Guid}")]
        public IActionResult GetById([FromRoute] Guid id)
        {
            // Region Domain Model data
            var region = _dbContext.Regions.Find(id);

            if (region == null) return NotFound();

            // Map/Convert Region domain model to Region DTO
            var regionDTO = new RegionDTO
            {
                Id = region.Id,
                Code = region.Code,
                Name = region.Name,
                RegionImageUrl = region.RegionImageUrl
            };

            return Ok(regionDTO);
        }

        [HttpPost("AddRegion")]
        public IActionResult AddRegion([FromBody] AddRegionRequestDTO addRegionRequestDTO)
        {
            // Map DTO to Domain model
            var regionDomainModel = new Region
            {
                Code = addRegionRequestDTO.Code,
                Name = addRegionRequestDTO.Name,
                RegionImageUrl = addRegionRequestDTO.RegionImageUrl
            };

            // Use Domain Model to Create Region in DB
            _dbContext.Regions.Add(regionDomainModel);
            _dbContext.SaveChanges();

            // Map domain model back to DTO
            var regionDTO = new RegionDTO
            {
                Id = regionDomainModel.Id,
                Code = regionDomainModel.Code,
                Name = regionDomainModel.Name,
                RegionImageUrl = regionDomainModel.RegionImageUrl
            };

            return CreatedAtAction(nameof(GetById), new { id = regionDomainModel.Id }, regionDTO);
        }

        [HttpDelete("DeleteRegion")]
        public IActionResult DeleteRegion(Guid id)
        {
            // Region Domain Model data
            var region = _dbContext.Regions.Find(id);

            if (region == null) return NotFound();

            _dbContext.Regions.Remove(region);
            _dbContext.SaveChanges();

            return NoContent();
        }

        [HttpPatch("UpdateRegion")]
        public IActionResult UpdateRegion(RegionDTO regionDTO)
        {
            // Region Domain Model data
            var regionDomainModel = _dbContext.Regions.Find(regionDTO.Id);

            if (regionDomainModel == null) return NotFound();

            regionDomainModel.Code = regionDTO.Code;
            regionDomainModel.Name = regionDTO.Name;
            regionDomainModel.RegionImageUrl = regionDTO.RegionImageUrl;


            // Update Domain Model in DB
            _dbContext.SaveChanges();

            return NoContent();
        }
    }
}