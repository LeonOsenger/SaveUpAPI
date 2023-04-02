using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SaveUpAPI.Models;

public partial class SaveUpContext : DbContext
{
    public SaveUpContext()
    {
    }

    public SaveUpContext(DbContextOptions<SaveUpContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Product> Products { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=.;Database=SaveUp;User Id=saveup;password=123;MultipleActiveResultSets=true;Encrypt=False;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //modelBuilder.Entity<Product>(entity =>
        //{
        //    entity.HasKey(e => e.Id).HasName("PK__Products__3214EC27CC8CE770");

        //    entity.Property(e => e.Id)
        //        .ValueGeneratedNever()
        //        .HasColumnName("ID");
        //    entity.Property(e => e.Description)
        //        .HasMaxLength(50)
        //        .IsUnicode(false);
        //});

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
