using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace QP.Entity.ModelBuilders
{
    public static class EntityBuilderExt
    {
        public static void BuilderBaseEntity<T>(this EntityTypeBuilder<T> builder) where T : BaseEntity
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd();

            builder.Property(p => p.IsDelete)
                .IsRequired()
                .HasDefaultValue(false);

            builder.Property(p => p.CreationTime)
                .HasMaxLength(0)
                .HasColumnType("datetime") //低版本mysql中需要指定为datetime
                .HasColumnName("CreationTime");
                //.HasDefaultValueSql("(now())");

            builder.Property(p => p.LastModificationTime)
                .HasMaxLength(0)
                .HasColumnType("datetime")
                .HasColumnName("LastModificationTime");
        }
    }
}
