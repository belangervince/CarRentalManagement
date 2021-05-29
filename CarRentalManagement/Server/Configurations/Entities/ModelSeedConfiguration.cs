using CarRentalManagement.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace CarRentalManagement.Server.Configurations.Entities
{
    public class ModelSeedConfiguration : IEntityTypeConfiguration<Model>
    {
        public void Configure(EntityTypeBuilder<Model> builder)
        {
            builder.HasData(
                new Model
                {
                    CreatedBy = "System",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    Name = "Prius",
                    UpdatedBy = "System"
                },
                new Model
                {
                    CreatedBy = "System",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    Name = "Vitz",
                    UpdatedBy = "System"
                },
                new Model
                {
                    CreatedBy = "System",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    Name = "3 Series",
                    UpdatedBy = "System"
                },
                new Model
                {
                    CreatedBy = "System",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    Name = "X5",
                    UpdatedBy = "System"
                });
        }
    }
}
