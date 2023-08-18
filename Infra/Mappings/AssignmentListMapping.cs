using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Mappings;

public class AssignmentListMapping :IEntityTypeConfiguration<AssingnmentList>
{
    public void Configure(EntityTypeBuilder<AssingnmentList> builder)
    {
        builder.HasKey(i => i.Id);

        builder
            .Property(n => n.Name)
            .HasColumnName("Name")
            .HasColumnType("VARCHAR(255)")
            .IsRequired();

        builder
            .Property(i => i.UserId)
            .IsRequired()
            .HasColumnName("User_Id");

        builder
            .HasMany(a => a.Assignments)
            .WithOne(a => a.AssingnmentList)
            .OnDelete(DeleteBehavior.Restrict);
    }
}