namespace NZWalks.Models.Domain
{
    public class Region
    {
        public Guid Id { get; set; }

        // Non - nullable props
        public string Code { get; set; }
        public string Name { get; set; }

        // Below prop is nullable i.e the DB table can contain null values for this column.
        public string? RegionImageUrl { get; set; }
    }
}