﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnionArchitectureProject.Api.Domain.Models;
using OnionArchitectureProject.Infrastructure.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitectureProject.Infrastructure.Persistence.EntityConfigurations
{
    public class UserEntityConfiguration : BaseEntityConfiguration<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);
            builder.ToTable("user", OnionArchitectureProjectContext.DEFAULT_SCHEMA);
        }
    }
    
    
}
