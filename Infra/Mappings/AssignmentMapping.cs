using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Mappings;

public class AssignmentMapping : IEntityTypeConfiguration<Assignment>
{
    public void Configure(EntityTypeBuilder<Assignment> builder)
    {
        builder.HasKey(i => i.Id);

        builder
            .Property(d => d.Description)
            .IsRequired()
            .HasColumnType("VARHCAR(255)")
            .HasColumnName("Description");

        builder
            .Property(c => c.Conclued)
            .IsRequired()
            .HasColumnName("Conclued")
            .HasColumnType("TINYINT");

        builder
            .Property(c => c.ConcluedAt)
            .HasColumnName("Conclued_At")
            .ValueGeneratedOnAdd()
            .HasColumnType("DATETIME");
        
        builder
            .Property(c => c.UpdatedAt)
            .HasColumnName("Updated_At")
            .ValueGeneratedOnUpdate()
            .HasColumnType("DATETIME");

        builder
            .Property(d => d.DeadLine)
            .HasColumnName("DeadLine")
            .HasColumnType("DATETIME");

        builder
            .Property(u => u.UserId)
            .IsRequired()
            .HasColumnName("User_Id");

        builder
            .Property(a => a.AssignmentListId)
            .HasColumnName("AssignmentList_Id");
        
       
    }
}