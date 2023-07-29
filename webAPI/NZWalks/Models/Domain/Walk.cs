namespace NZWalks.Models.Domain
{
    public class Walk
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double LengthInKm { get; set; }
        public string? WalkImageUrl { get; set; }

        public Guid DifficultyId { get; set; }
        public Guid RegionId { get; set; }

        // Navigation properties - Tells EF that a Walk will have a Difficulty and this is the DifficultyId at line 10
        // Defines a One to One relationship between Walk and Difficulty, Walk and Region
        public Difficulty Difficulty { get; set; }
        public Region Region { get; set; }
    }
}