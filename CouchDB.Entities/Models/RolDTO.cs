using System.Collections.Generic;

namespace Presentation.Entities.Models
{
    public class RolDTO : BaseDTO
    {
        public string RolName { get; set; }

        public List<PageDTO> Pages { get; set; }
    }
}
