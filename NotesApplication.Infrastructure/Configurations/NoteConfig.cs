﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NotesApplication.Domain.Aggregates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesApplication.Infrastructure.Configurations
{
    public class NoteConfig : IEntityTypeConfiguration<Note>
    {
        public void Configure(EntityTypeBuilder<Note> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Title).IsRequired();
            builder.Property(x => x.Content).IsRequired();
            builder.Property(x => x.DateCreated).IsRequired();
            builder.Property(x => x.LastModified).IsRequired();
        }
    }
}
