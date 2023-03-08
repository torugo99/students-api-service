using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using studentsAPI.Models.Entities;

namespace studentsAPI.Infrastructure.EntityConfig
{
    public class BaseMap<T> : IEntityTypeConfiguration<T> where T : Base
    {
        private readonly string _tableName;

        public BaseMap(string tableName)
        {
            _tableName = tableName;
        }
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            if (!string.IsNullOrEmpty(_tableName)) builder.ToTable(_tableName);

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .HasColumnName("id")
                .ValueGeneratedOnAdd();
            builder.Property(x => x.CreatedAt)
                .HasColumnName("created_at");
            builder.Property(x => x.UpdatedAt)
                .HasColumnName("updated_at");
            builder.Property(x => x.IsActive)
                .HasColumnName("is_active");
        }
    }
}