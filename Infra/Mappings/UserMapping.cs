using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Mappings;

public class UserMapping : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.HasKey(i => i.Id);
        
        builder
            .Property(n => n.Nome)
            .IsRequired()
            .HasColumnType("VARHCAR(255)")
            .HasColumnName("Name");

        builder
            .Property(e => e.Email)
            .IsRequired()
            .HasColumnType("VARCHAR(80)")
            .HasColumnName("Email");

        builder
            .Property(p => p.Password)
            .IsRequired()
            .HasColumnType("VARCHAR(20)")
            .HasColumnName("Password");

        builder
            .Property(c => c.CreatedAt)
            .HasColumnType("DATETIME")
            .HasColumnName("Created_At")
            .ValueGeneratedOnAdd();

        builder
            .Property(u => u.UpdatedAt)
            .HasColumnType("DATETIME")
            .HasColumnName("Updated_At")
            .ValueGeneratedOnUpdate();

        builder
            .HasMany(a => a.Assignments)
            .WithOne(a => a.User)
            .HasForeignKey(a => a.UserId)
            .OnDelete(DeleteBehavior.Restrict);

        builder
            .HasMany(b => b.AssignmentLists)
            .WithOne(b => b.user)
            .OnDelete(DeleteBehavior.Restrict);
    }
}