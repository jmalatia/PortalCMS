﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace Portal.CMS.Web.Areas.Admin.ViewModels.Authentication
{
    public class AvatarViewModel
    {
        [DisplayName("Avatar")]
        [Required]
        public HttpPostedFileBase AttachedImage { get; set; }
    }
}