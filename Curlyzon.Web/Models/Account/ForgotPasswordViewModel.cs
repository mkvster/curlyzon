using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Curlyzon.Web.Models.Account
{
    public class ForgotPasswordViewModel
    {
        [Required]
        [Display(Name = "User Name")]
        public string UserName { get; set; }
    }
}