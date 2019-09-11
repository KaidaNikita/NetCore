using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TUZARTEMA.DAL.Entities
{
    public class DbContext:IdentityDbContext<DbUser, DbRole, string, IdentityUserClaim<string>,
                              DbUserRole, IdentityUserLogin<string>,
                              IdentityRoleClaim<string>, IdentityUserToken<string>>
    {
        public DbSet<DBUserProfile> usersprofiles { get; set; }
        public DbSet<DBCity> cities { get; set; }

        public DbContext(DbContextOptions<DbContext> options)
            :base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder.Query<BrokerProfileModel>().ToView("vBrokersProfile");

            base.OnModelCreating(builder);

            builder.Entity<DbUserRole>(userRole =>
            {
                userRole.HasKey(ur => new
                {
                    ur.UserId,
                    ur.RoleId
                });



                userRole.HasOne(ur => ur.Role)
                    .WithMany(r => r.UserRoles)
                    .HasForeignKey(ur => ur.RoleId)
                    .IsRequired();



                userRole.HasOne(ur => ur.User)
                                .WithMany(r => r.UserRoles)
                                .HasForeignKey(ur => ur.UserId)
                                .IsRequired();
            });
        }
    }
}
