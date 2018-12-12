using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Demo.FE.Models
{
    public class AccountModel
    {
        public string userName { get; set; }
        [Required]
        public string password { get; set; }
    }
}