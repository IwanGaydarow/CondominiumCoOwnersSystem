namespace CondominiumCoOwnersSystem.Data.Configurations
{
    using CondominiumCoOwnersSystem.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class BuildingFundRepairConfiguration : IEntityTypeConfiguration<Building>
    {
        public void Configure(EntityTypeBuilder<Building> builder)
        {
            builder.HasOne(b => b.FundRepair)
                .WithOne(f => f.Building)
                .HasForeignKey<FundRepair>(f => f.BuildingId);
        }
    }
}
