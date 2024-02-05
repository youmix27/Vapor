using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace POCSQLCO.Models;

public partial class VaporContext : DbContext
{
    public VaporContext()
    {
    }

    public VaporContext(DbContextOptions<VaporContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Commande> Commandes { get; set; }

    public virtual DbSet<ContenuCommande> ContenuCommandes { get; set; }

    public virtual DbSet<Developpeur> Developpeurs { get; set; }

    public virtual DbSet<Distributeur> Distributeurs { get; set; }

    public virtual DbSet<Genre> Genres { get; set; }

    public virtual DbSet<Jeu> Jeux { get; set; }

    public virtual DbSet<Notation> Notations { get; set; }

    public virtual DbSet<Theme> Themes { get; set; }

    public virtual DbSet<Utilisateur> Utilisateurs { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Commande>(entity =>
        {
            entity.HasKey(e => new { e.Id, e.UtilisateurId });

            entity.ToTable("Commande");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.UtilisateurId).HasColumnName("utilisateur_id");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.EstTermine).HasColumnName("estTermine");

            entity.HasOne(d => d.Utilisateur).WithMany(p => p.Commandes)
                .HasForeignKey(d => d.UtilisateurId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Commande_Utilisateur");
        });

        modelBuilder.Entity<ContenuCommande>(entity =>
        {
            entity.HasKey(e => new { e.UtilisateurId, e.CommandeId, e.JeuId });

            entity.ToTable("ContenuCommande");

            entity.Property(e => e.CommandeId).HasColumnName("commande_id");
            entity.Property(e => e.JeuId).HasColumnName("jeu_id");
            entity.Property(e => e.UtilisateurId).HasColumnName("utilisateur_id");

            entity.HasOne(d => d.Jeu).WithMany(p => p.ContenuCommandes)
                .HasForeignKey(d => d.JeuId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ContenuCommande_Jeu");

            entity.HasOne(d => d.Commande).WithMany(p => p.ContenuCommandes)
                .HasForeignKey(d => new { d.CommandeId, d.UtilisateurId })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ContenuCommande_Commande");
        });

        modelBuilder.Entity<Developpeur>(entity =>
        {
            entity.ToTable("Developpeur");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.Libelle)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("libelle");
            entity.Property(e => e.Logo)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("logo");
        });

        modelBuilder.Entity<Distributeur>(entity =>
        {
            entity.ToTable("Distributeur");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.Libelle)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("libelle");
            entity.Property(e => e.Logo)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("logo");
        });

        modelBuilder.Entity<Genre>(entity =>
        {
            entity.ToTable("Genre");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Libelle)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("libelle");
        });

        modelBuilder.Entity<Jeu>(entity =>
        {
            entity.ToTable("Jeu");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ContientCs).HasColumnName("contient_CS");
            entity.Property(e => e.ContientGore).HasColumnName("contient_gore");
            entity.Property(e => e.DateDeSortie).HasColumnName("date_de_sortie");
            entity.Property(e => e.Description)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.DeveloppeurId).HasColumnName("developpeur_id");
            entity.Property(e => e.DistributeurId).HasColumnName("distributeur_id");
            entity.Property(e => e.EstMultijoueur).HasColumnName("est_multijoueur");
            entity.Property(e => e.Jaquette)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("jaquette");
            entity.Property(e => e.Libelle)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("libelle");
            entity.Property(e => e.Prix)
                .HasColumnType("decimal(6, 2)")
                .HasColumnName("prix");

            entity.HasOne(d => d.Developpeur).WithMany(p => p.Jeus)
                .HasForeignKey(d => d.DeveloppeurId)
                .HasConstraintName("FK_Jeu_Developpeur");

            entity.HasOne(d => d.Distributeur).WithMany(p => p.Jeus)
                .HasForeignKey(d => d.DistributeurId)
                .HasConstraintName("FK_Jeu_Distributeur");

            entity.HasMany(d => d.Genres).WithMany(p => p.Jeus)
                .UsingEntity<Dictionary<string, object>>(
                    "ContientGenre",
                    r => r.HasOne<Genre>().WithMany()
                        .HasForeignKey("GenreId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_ContientGenre_Genre"),
                    l => l.HasOne<Jeu>().WithMany()
                        .HasForeignKey("JeuId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_ContientGenre_Jeu"),
                    j =>
                    {
                        j.HasKey("JeuId", "GenreId");
                        j.ToTable("ContientGenre");
                        j.IndexerProperty<int>("JeuId").HasColumnName("jeu_id");
                        j.IndexerProperty<int>("GenreId").HasColumnName("genre_id");
                    });

            entity.HasMany(d => d.Themes).WithMany(p => p.Jeus)
                .UsingEntity<Dictionary<string, object>>(
                    "ContientTheme",
                    r => r.HasOne<Theme>().WithMany()
                        .HasForeignKey("ThemeId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_ContientTheme_Theme"),
                    l => l.HasOne<Jeu>().WithMany()
                        .HasForeignKey("JeuId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_ContientTheme_Jeu"),
                    j =>
                    {
                        j.HasKey("JeuId", "ThemeId");
                        j.ToTable("ContientTheme");
                        j.IndexerProperty<int>("JeuId").HasColumnName("jeu_id");
                        j.IndexerProperty<int>("ThemeId").HasColumnName("theme_id");
                    });
        });

        modelBuilder.Entity<Notation>(entity =>
        {
            entity.HasKey(e => new { e.UtilisateurId, e.JeuId });

            entity.ToTable("Notation");

            entity.Property(e => e.UtilisateurId).HasColumnName("utilisateur_id");
            entity.Property(e => e.JeuId).HasColumnName("jeu_id");
            entity.Property(e => e.Commentaire)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("commentaire");
            entity.Property(e => e.Recommande).HasColumnName("recommande");

            entity.HasOne(d => d.Jeu).WithMany(p => p.Notations)
                .HasForeignKey(d => d.JeuId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Notation_Jeu");

            entity.HasOne(d => d.Utilisateur).WithMany(p => p.Notations)
                .HasForeignKey(d => d.UtilisateurId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Notation_Utilisateur");
        });

        modelBuilder.Entity<Theme>(entity =>
        {
            entity.ToTable("Theme");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Libelle)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("libelle");
        });

        modelBuilder.Entity<Utilisateur>(entity =>
        {
            entity.ToTable("Utilisateur");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Adresse)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.CodePostal)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("code_postal");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.FiltreCs).HasColumnName("filtre_CS");
            entity.Property(e => e.FiltreGore).HasColumnName("filtre_gore");
            entity.Property(e => e.HashMdp)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("hashMDP");
            entity.Property(e => e.IsAdmin).HasColumnName("is_admin");
            entity.Property(e => e.Nom)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nom");
            entity.Property(e => e.Prenom)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("prenom");
            entity.Property(e => e.Pseudo)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("pseudo");
            entity.Property(e => e.Salt)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("salt");
            entity.Property(e => e.Telephone)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("telephone");
            entity.Property(e => e.Ville)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ville");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
