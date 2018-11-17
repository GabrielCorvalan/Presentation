namespace Presentation.Entities.Models
{
    public class AddressDTO
    {
        public int CityId { get; set; }
        public int ZipCode { get; set; }
        public string Streets { get; set; }
        public int HouseNumber { get; set; }

        public CityDTO City { get; set; }
    }
}
