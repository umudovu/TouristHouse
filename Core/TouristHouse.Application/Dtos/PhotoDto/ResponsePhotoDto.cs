namespace TouristHouse.Application.Dtos.PhotoDto
{
    public class ResponsePhotoDto
    {
        public string? Id { get; set; }

        public string? ImageUrl { get; set; }
        public string? ImagePublicId { get; set; }

        public bool IsMain { get; set; }
        public string? AnnounceId { get; set; }
    }
}
