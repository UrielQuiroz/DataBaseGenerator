using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace LectorExcel.Models;

public partial class PruebamtosContext : DbContext
{
    public PruebamtosContext()
    {
    }

    public PruebamtosContext(DbContextOptions<PruebamtosContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Mob> Mobs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=pruebamtos.mssql.somee.com;Initial Catalog=pruebamtos;Persist Security Info=False;User ID=uquiroz_SQLLogin_1;Password=data2010;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=True;Connection Timeout=30;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Mob>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__mobs__3213E83F1467E844");

            entity.ToTable("mobs");

            entity.Property(e => e.Id)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("id");
            entity.Property(e => e.Age)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("age");
            entity.Property(e => e.ApeMat)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("ape_mat");
            entity.Property(e => e.ApePat)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("ape_pat");
            entity.Property(e => e.Apes)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("apes");
            entity.Property(e => e.Cda)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("cda");
            entity.Property(e => e.Col)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("col");
            entity.Property(e => e.Cp)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("cp");
            entity.Property(e => e.Cta)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("cta");
            entity.Property(e => e.Curp)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("curp");
            entity.Property(e => e.Cve)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("cve");
            entity.Property(e => e.Dir)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("dir");
            entity.Property(e => e.Edo)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("edo");
            entity.Property(e => e.Email)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Gender)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("gender");
            entity.Property(e => e.Mpo)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("mpo");
            entity.Property(e => e.Nom)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("nom");
            entity.Property(e => e.NomCom)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("nom_com");
            entity.Property(e => e.Pdto)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("pdto");
            entity.Property(e => e.Rfc)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("rfc");
            entity.Property(e => e.Tabla)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("tabla");
            entity.Property(e => e.Tdcb)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("tdcb");
            entity.Property(e => e.Tel1)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("tel1");
            entity.Property(e => e.Tel2)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("tel2");
            entity.Property(e => e.Tel3)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("tel3");
            entity.Property(e => e.Tel4)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("tel4");
            entity.Property(e => e.Tel5)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("tel5");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
