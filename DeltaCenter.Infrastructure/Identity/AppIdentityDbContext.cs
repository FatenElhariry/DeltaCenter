﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DeltaCenter.Infrastructure.Identity
{
    public class AppIdentityDbContext:IdentityDbContext<ApplicationUser>
    {
        public AppIdentityDbContext(DbContextOptions<AppIdentityDbContext> options)
           : base(options)
        {
        }
    }
}
