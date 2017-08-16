using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using Marley.Currency.Domain.DataEntities;

namespace Marley.Currency.Data.EntityConfig.Mapping
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            HasKey(k => k.Id);

            Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(80);

            Property(p => p.Email)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnAnnotation(IndexAnnotation.AnnotationName, new IndexAnnotation(new IndexAttribute("UQ_User_Email", 1) { IsUnique = true }));

            Property(p => p.Telephone)
                .HasMaxLength(15);

            Property(p => p.Login)
                .IsRequired()
                .HasMaxLength(40)
                .HasColumnAnnotation(IndexAnnotation.AnnotationName, new IndexAnnotation(new IndexAttribute("UQ_User_Login", 2) { IsUnique = true }));

            Property(p => p.Password)
                .HasMaxLength(500);

            HasRequired(p => p.Profile)
                .WithMany()
                .HasForeignKey(f => f.ProfileId);

        }
    }
}