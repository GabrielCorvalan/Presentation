namespace Presentation.Entities.Models
{
    public class ProvinceDTO : BaseDTO
    {
        public string ProvinceName { get; set; }
        public int CountryId { get; set; }

        public CountryDTO Country { get; set; }
    }
}
