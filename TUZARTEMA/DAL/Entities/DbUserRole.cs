﻿using Microsoft.AspNetCore.Identity;

namespace TUZARTEMA.DAL.Entities
{
    public class DbUserRole:IdentityUserRole<string>
    {
        public virtual DbUser User { get; set; }

        public virtual DbRole Role { get; set; }
    }
}