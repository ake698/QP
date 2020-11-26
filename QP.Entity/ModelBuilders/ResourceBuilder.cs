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

            b.HasData(
                new Resource { Id=2, Name="稳定", Link= "http://api.iokzy.com/", CreationTime = DateTime.Now },
                new Resource { Id=1, Name="高清", Link= "http://www.zuidazy4.net/", CreationTime = DateTime.Now }
            );
        }
    }
}
