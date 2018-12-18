using System.ComponentModel.DataAnnotations;

namespace Hourly.FE.Models
{
    public class AccountModel
    {
        public string userName { get; set; }
        [Required]
        public string password { get; set; }
    }
}