using CharanpreeetSingh.Entities;

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CharanpreetSingh.DataBaseContext
{
    public class CharanPreetDBContext : DbContext
    {
        public CharanPreetDBContext(DbContextOptions<CharanPreetDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Profile> Profile { get; set; }

        public virtual DbSet<Experience> Experience { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    OnModelCreatingPartial(modelBuilder);
        //}

        //private void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}