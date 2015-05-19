using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcCms.Areas.Admin.ViewModels
{
    using System.ComponentModel.DataAnnotations;

    public class InfoViewModel
    {
        [Required]
        [Display(Name = "Username")]
        public string UserName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Display Name")]
        public string DisplayName { get; set; }

        [Display(Name = "Roles")]
        public string Roles { get; set; }

        [Display(Name = "IsAuthenticated")]
        public bool IsAuthenticated { get; set; }

        [Display(Name = "Message")]
        public string Message { get; set; }

    }
}