using System.ComponentModel.DataAnnotations;

namespace SearchCifApi.Models
{
    public class CifUser
    {
        [Key]
        public int CifId { get; set; }
        [Required]
        public string emailId { get; set; }
    }
}
