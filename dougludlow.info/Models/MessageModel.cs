using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace dougludlow.info.Models
{
    public class MessageModel
    {
        [Required, MinLength(2), MaxLength(255)]
        public string Name { get; set; }

        [Required, EmailAddress, MaxLength(255)]
        public string Email { get; set; }

        [Required, MinLength(2), MaxLength(1024)]
        public string Message { get; set; }
    }
}