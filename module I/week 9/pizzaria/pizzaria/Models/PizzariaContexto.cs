using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace pizzaria.Models;

public partial class PizzariaContexto : DbContext
{
    public PizzariaContexto()
    {
    }

    public PizzariaContexto(DbContextOptions<PizzariaContexto> options)
        : base(options)
    {
    }

    public virtual DbSet<Bordum> Borda { get; set; }

    public virtual DbSet<Massa> Massas { get; set; }

    public virtual DbSet<Pedido> Pedidos { get; set; }

    public virtual DbSet<Pizza> Pizzas { get; set; }

    public virtual DbSet<PizzaSabore> PizzaSabores { get; set; }

    public virtual DbSet<Sabor> Sabors { get; set; }

    public virtual DbSet<Status> Statuses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-AEEPB0N\\SQLEXPRESS;Database=pizzaria;User ID=sa;Password=*********;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Bordum>(entity =>
        {
            entity.HasKey(e => e.IdBorda).HasName("PK__borda__B922CACA0A26D361");

            entity.ToTable("borda");

            entity.Property(e => e.IdBorda).HasColumnName("idBorda");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<Massa>(entity =>
        {
            entity.HasKey(e => e.IdMassa).HasName("PK__massa__70C35DBF5211BDBF");

            entity.ToTable("massa");

            entity.Property(e => e.IdMassa).HasColumnName("idMassa");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<Pedido>(entity =>
        {
            entity.HasKey(e => e.IdPedido).HasName("PK__pedido__A9F619B76BE95A6B");

            entity.ToTable("pedido");

            entity.HasIndex(e => e.PizzaId, "UC_pizza_pedido").IsUnique();

            entity.Property(e => e.IdPedido).HasColumnName("idPedido");
            entity.Property(e => e.PizzaId).HasColumnName("pizzaId");
            entity.Property(e => e.StatusId).HasColumnName("statusId");

            entity.HasOne(d => d.Pizza).WithOne(p => p.Pedido)
                .HasForeignKey<Pedido>(d => d.PizzaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_pedido_pizza");

            entity.HasOne(d => d.Status).WithMany(p => p.Pedidos)
                .HasForeignKey(d => d.StatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_status_pizza");
        });

        modelBuilder.Entity<Pizza>(entity =>
        {
            entity.HasKey(e => e.IdPizza).HasName("PK__pizza__FF3E5D510D450ADF");

            entity.ToTable("pizza");

            entity.Property(e => e.IdPizza).HasColumnName("idPizza");
            entity.Property(e => e.BordaId).HasColumnName("bordaId");
            entity.Property(e => e.MassaId).HasColumnName("massaId");

            entity.HasOne(d => d.Borda).WithMany(p => p.Pizzas)
                .HasForeignKey(d => d.BordaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_pizzA_borda");

            entity.HasOne(d => d.Massa).WithMany(p => p.Pizzas)
                .HasForeignKey(d => d.MassaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_pizza_massa");
        });

        modelBuilder.Entity<PizzaSabore>(entity =>
        {
            entity.HasKey(e => e.IdPizzaSabores).HasName("PK__pizzaSab__895BE9A65A1D56B0");

            entity.ToTable("pizzaSabores");

            entity.Property(e => e.IdPizzaSabores).HasColumnName("idPizzaSabores");
            entity.Property(e => e.PizzaId).HasColumnName("pizzaId");
            entity.Property(e => e.SaborId).HasColumnName("saborId");

            entity.HasOne(d => d.Pizza).WithMany(p => p.PizzaSabores)
                .HasForeignKey(d => d.PizzaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_pizzaSabores_pizza");

            entity.HasOne(d => d.Sabor).WithMany(p => p.PizzaSabores)
                .HasForeignKey(d => d.SaborId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_pizzaSabores_sabor");
        });

        modelBuilder.Entity<Sabor>(entity =>
        {
            entity.HasKey(e => e.IdSabor).HasName("PK__sabor__B088378BCFCE29C9");

            entity.ToTable("sabor");

            entity.Property(e => e.IdSabor).HasColumnName("idSabor");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nome");
        });

        modelBuilder.Entity<Status>(entity =>
        {
            entity.HasKey(e => e.IdStatus).HasName("PK__status__01936F74C7AB390D");

            entity.ToTable("status");

            entity.Property(e => e.IdStatus).HasColumnName("idStatus");
            entity.Property(e => e.Nome)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nome");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
