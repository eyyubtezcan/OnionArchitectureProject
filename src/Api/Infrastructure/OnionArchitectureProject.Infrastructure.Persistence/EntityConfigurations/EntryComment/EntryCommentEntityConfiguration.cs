using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnionArchitectureProject.Infrastructure.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitectureProject.Infrastructure.Persistence.EntityConfigurations.EntryComment
{
    public class EntryCommentEntityConfiguration: BaseEntityConfiguration<Api.Domain.Models.EntryComment>
    {
        public override void Configure(EntityTypeBuilder<Api.Domain.Models.EntryComment> builder)
        {
            base.Configure(builder);
            builder.ToTable("entrycomment", OnionArchitectureProjectContext.DEFAULT_SCHEMA);

            builder.HasOne(x => x.CreatedBy)
                .WithMany(i => i.EntryComments)
                .HasForeignKey(i => i.CreatedById)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Entry)
                .WithMany(i => i.EntrtyComments)
                .HasForeignKey(i => i.EntryId);

        }
    
    }
}
