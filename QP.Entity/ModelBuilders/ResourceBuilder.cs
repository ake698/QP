using Microsoft.EntityFrameworkCore;
using System;

namespace QP.Entity.ModelBuilders
{
    public class ResourceBuilder
    {
        public ResourceBuilder(ModelBuilder builder)
        {
            var b = builder.Entity<Resource>();
            b.ToTable("data_Resource");
            b.BuilderBaseEntity();

            b.HasData(new Resource { Id=1, Name="OK", Link= "http://api.iokzy.com/", CreationTime = DateTime.Now });
        }
    }
}
