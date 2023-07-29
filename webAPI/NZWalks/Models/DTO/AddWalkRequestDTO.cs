using NZWalks.Models.Domain;

namespace NZWalks.Models.DTO
{
    public class AddWalkRequestDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double LengthInKm { get; set; }
        public string? WalkImageUrl { get; set; }

        public Guid DifficultyId { get; set; }
        public Guid RegionId { get; set; }
        // public Difficulty Difficulty { get; set; }
        // public Region Region { get; set; }
    }
}