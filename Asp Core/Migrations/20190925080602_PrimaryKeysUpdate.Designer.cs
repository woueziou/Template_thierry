﻿// <auto-generated />
using System;
using Gestion_Location.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Gestion_Location.Migrations
{
    [DbContext(typeof(rentmanagerContext))]
    [Migration("20190925080602_PrimaryKeysUpdate")]
    partial class PrimaryKeysUpdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Gestion_Location.Models.Appartement", b =>
                {
                    b.Property<string>("idAppartement")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10);

                    b.Property<int>("caution");

                    b.Property<string>("description");

                    b.Property<string>("libelleAppartement");

                    b.Property<int>("loyer");

                    b.HasKey("idAppartement");

                    b.ToTable("Appartements");
                });

            modelBuilder.Entity("Gestion_Location.Models.Contrat", b =>
                {
                    b.Property<string>("idContrat")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10);

                    b.Property<string>("ImmeubleidImmeuble");

                    b.Property<int>("commission");

                    b.Property<DateTime>("dateDeb");

                    b.Property<DateTime>("dateFin");

                    b.Property<int>("idImmeuble");

                    b.Property<string>("libelleContrat");

                    b.HasKey("idContrat");

                    b.HasIndex("ImmeubleidImmeuble");

                    b.ToTable("Contrats");
                });

            modelBuilder.Entity("Gestion_Location.Models.ContratLocation", b =>
                {
                    b.Property<string>("idContratLocation")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10);

                    b.Property<string>("idAppartement");

                    b.Property<string>("idImmeuble");

                    b.Property<string>("idLocataire");

                    b.Property<string>("libelle");

                    b.HasKey("idContratLocation");

                    b.HasIndex("idAppartement");

                    b.HasIndex("idImmeuble");

                    b.HasIndex("idLocataire");

                    b.ToTable("ContratLocations");
                });

            modelBuilder.Entity("Gestion_Location.Models.Immeuble", b =>
                {
                    b.Property<string>("idImmeuble")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10);

                    b.Property<string>("Proprietaireid");

                    b.Property<string>("description");

                    b.Property<string>("idProprietaire");

                    b.Property<string>("libelle");

                    b.HasKey("idImmeuble");

                    b.HasIndex("Proprietaireid");

                    b.ToTable("Immeubles");
                });

            modelBuilder.Entity("Gestion_Location.Models.Locataire", b =>
                {
                    b.Property<string>("idLocataire")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10);

                    b.Property<string>("nom")
                        .HasMaxLength(30);

                    b.Property<string>("prenom")
                        .HasMaxLength(30);

                    b.Property<int>("tel");

                    b.HasKey("idLocataire");

                    b.ToTable("Locataires");
                });

            modelBuilder.Entity("Gestion_Location.Models.Payement", b =>
                {
                    b.Property<string>("idProprietaire")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10);

                    b.Property<string>("commentaire");

                    b.Property<DateTime>("datePayement");

                    b.Property<string>("idContratLocation");

                    b.Property<int>("montant");

                    b.HasKey("idProprietaire");

                    b.HasIndex("idContratLocation");

                    b.ToTable("Payements");
                });

            modelBuilder.Entity("Gestion_Location.Models.Proprietaire", b =>
                {
                    b.Property<string>("id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10);

                    b.Property<string>("adresse");

                    b.Property<string>("nom");

                    b.Property<string>("prenom");

                    b.Property<int>("telephone");

                    b.HasKey("id");

                    b.ToTable("Proprietaires");
                });

            modelBuilder.Entity("Gestion_Location.Models.Retrait", b =>
                {
                    b.Property<string>("idRetrait")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10);

                    b.Property<string>("commentaires");

                    b.Property<DateTime>("dateRetrait");

                    b.Property<string>("idContrat");

                    b.Property<int>("montant");

                    b.HasKey("idRetrait");

                    b.HasIndex("idContrat");

                    b.ToTable("Retraits");
                });

            modelBuilder.Entity("Gestion_Location.Models.Contrat", b =>
                {
                    b.HasOne("Gestion_Location.Models.Immeuble", "Immeuble")
                        .WithMany("Contrats")
                        .HasForeignKey("ImmeubleidImmeuble");
                });

            modelBuilder.Entity("Gestion_Location.Models.ContratLocation", b =>
                {
                    b.HasOne("Gestion_Location.Models.Appartement", "Appartement")
                        .WithMany("ContratLocations")
                        .HasForeignKey("idAppartement");

                    b.HasOne("Gestion_Location.Models.Immeuble", "Immeuble")
                        .WithMany("ContratLocations")
                        .HasForeignKey("idImmeuble");

                    b.HasOne("Gestion_Location.Models.Locataire", "Locataire")
                        .WithMany("ContratLocations")
                        .HasForeignKey("idLocataire");
                });

            modelBuilder.Entity("Gestion_Location.Models.Immeuble", b =>
                {
                    b.HasOne("Gestion_Location.Models.Proprietaire", "Proprietaire")
                        .WithMany("Immeubles")
                        .HasForeignKey("Proprietaireid");
                });

            modelBuilder.Entity("Gestion_Location.Models.Payement", b =>
                {
                    b.HasOne("Gestion_Location.Models.ContratLocation", "ContratLocation")
                        .WithMany("Payements")
                        .HasForeignKey("idContratLocation");
                });

            modelBuilder.Entity("Gestion_Location.Models.Retrait", b =>
                {
                    b.HasOne("Gestion_Location.Models.Contrat", "Contrat")
                        .WithMany("Retraits")
                        .HasForeignKey("idContrat");
                });
#pragma warning restore 612, 618
        }
    }
}
