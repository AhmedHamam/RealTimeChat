﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace RealChat.Domain.Domains.User
{
    public class UserToken : IdentityUserToken<int>
    {
        [NotMapped]
        public virtual ApplicationUser User { get; set; }
    }
}