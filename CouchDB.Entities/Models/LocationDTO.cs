namespace Presentation.Entities.Models
{
    public class LocationDTO : BaseDTO
    {
        public string LocationName  { get; set; }
        public int ProvinceId { get; set; }

        public ProvinceDTO Province { get; set; }
    }
}
