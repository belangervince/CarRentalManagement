using CarRentalManagement.Server.Models;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace CarRentalManagement.Server.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "a9394b64-77ed-4f53-8127-50cc61a5ca24",
                    UserId = "b9394b64-77ed-4f53-8127-50cc61a5ca23"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "a9394b64-77ed-4f53-8127-50cc61a5ca23",
                    UserId = "b8394b64-77ed-4f53-8127-50cc61a5ca23"
                });
        }
    }
}
