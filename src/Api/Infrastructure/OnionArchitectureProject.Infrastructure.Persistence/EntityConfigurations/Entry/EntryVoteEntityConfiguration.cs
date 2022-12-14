using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnionArchitectureProject.Api.Domain.Models;
using OnionArchitectureProject.Infrastructure.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitectureProject.Infrastructure.Persistence.EntityConfigurations.Entry
{
    public class EntryVoteEntityConfiguration: BaseEntityConfiguration<EntryVote>
    {
        public override void Configure(EntityTypeBuilder<EntryVote> builder)
        {
            base.Configure(builder);
            builder.ToTable("entryvote", OnionArchitectureProjectContext.DEFAULT_SCHEMA);

            builder.HasOne(x => x.Entry)
                .WithMany(i => i.EntryVotes)
                .HasForeignKey(i => i.EntryId);


        }
    
    }
}
