using TouristHouse.Domain.Entites.Common;

namespace TouristHouse.Domain.Entites
{
    public class AnnounceTag:BaseEntity
    {
        public string? Name { get; set; }

        public List<Announce>? Announces { get; set; }
    }
}
