using System.ComponentModel.DataAnnotations;

namespace SearchCifApi.Models.Dto
{
    public class CifUserDto
    {
        public int CifId { get; set; }

        public string emailId { get; set; }
    }
}
