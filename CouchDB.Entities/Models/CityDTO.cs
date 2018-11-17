namespace Presentation.Entities.Models
{
    public class CityDTO : BaseDTO
    {
        public string CityName { get; set; }
        public int LocationId { get; set; }
        public LocationDTO Location { get; set; }
    }
}
