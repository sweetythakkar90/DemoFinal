using System.ComponentModel.DataAnnotations;

namespace Hourly.FE.Models
{
    public class AccountModel
    {
        [Required]
        public string firstName { get; set; }
        [Required]
        public string lastName { get; set; }
        [Required]
        public string company { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public string password { get; set; }
    }
}