using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QP.Entity.ModelBuilders
{
    public static class EntityBuilderExt
    {
        public static void BuilderBaseEntity<T>(this EntityTypeBuilder<T> builder) where T : BaseEntity<int>
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd();

            builder.Property(p => p.IsDelete)
                .IsRequired()
                .HasDefaultValue(false);
        }

        public static void BuilderFullEntity<T>(this EntityTypeBuilder<T> builder) where T : FullEntity<int>
        {
            builder.BuilderBaseEntity<T>();

            builder.Property(p => p.CreationTime)
                .HasColumnName("CreationTime")
                .HasDefaultValueSql("(now())");

            builder.Property(p => p.LastModificationTime)
                .HasColumnName("LastModificationTime");
        }
    }
}
