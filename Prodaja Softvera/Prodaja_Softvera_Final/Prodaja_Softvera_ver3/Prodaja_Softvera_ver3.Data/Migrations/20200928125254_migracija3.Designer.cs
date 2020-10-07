﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Prodaja_Softvera_ver3.Data.EF;

namespace Prodaja_Softvera_ver3.Data.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20200928125254_migracija3")]
    partial class migracija3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Prodaja_Softvera_ver3.Data.EntityModels.Analiza", b =>
                {
                    b.Property<int>("AnalizaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Datum_analize")
                        .HasColumnType("datetime2");

                    b.Property<int>("KlijentID")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SoftverID")
                        .HasColumnType("int");

                    b.Property<int>("ZaposlenikID")
                        .HasColumnType("int");

                    b.HasKey("AnalizaID");

                    b.HasIndex("KlijentID");

                    b.HasIndex("SoftverID");

                    b.HasIndex("ZaposlenikID");

                    b.ToTable("Analiza");
                });

            modelBuilder.Entity("Prodaja_Softvera_ver3.Data.EntityModels.AutorizacijskiToken", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("KorisnickiNalogId")
                        .HasColumnType("int");

                    b.Property<string>("Vrijednost")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("VrijemeEvidentiranja")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("KorisnickiNalogId");

                    b.ToTable("AutorizacijskiToken");
                });

            modelBuilder.Entity("Prodaja_Softvera_ver3.Data.EntityModels.Drzava", b =>
                {
                    b.Property<int>("DrzavaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Oznaka")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DrzavaID");

                    b.ToTable("Drzava");
                });

            modelBuilder.Entity("Prodaja_Softvera_ver3.Data.EntityModels.Fakultet", b =>
                {
                    b.Property<int>("FakultetID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Univerzitet")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FakultetID");

                    b.ToTable("Fakultet");
                });

            modelBuilder.Entity("Prodaja_Softvera_ver3.Data.EntityModels.Grad", b =>
                {
                    b.Property<int>("GradID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DrzavaID")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GradID");

                    b.HasIndex("DrzavaID");

                    b.ToTable("Grad");
                });

            modelBuilder.Entity("Prodaja_Softvera_ver3.Data.EntityModels.Kartica", b =>
                {
                    b.Property<int>("KarticaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BrojKartice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Iznos")
                        .HasColumnType("float");

                    b.HasKey("KarticaID");

                    b.ToTable("Kartica");
                });

            modelBuilder.Entity("Prodaja_Softvera_ver3.Data.EntityModels.Klijent", b =>
                {
                    b.Property<int>("KlijentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Datum_rodjenja")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GradID")
                        .HasColumnType("int");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KarticaID")
                        .HasColumnType("int");

                    b.Property<string>("Kontakt_broj")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("KorisnickiNalogID")
                        .HasColumnType("int");

                    b.Property<string>("Prezime")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KlijentID");

                    b.HasIndex("GradID");

                    b.HasIndex("KarticaID");

                    b.HasIndex("KorisnickiNalogID");

                    b.ToTable("Klijent");
                });

            modelBuilder.Entity("Prodaja_Softvera_ver3.Data.EntityModels.KorisnickiNalog", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("KorisnickoIme")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Lozinka")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipKorisnickogNaloga")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("KorisnickiNalog");
                });

            modelBuilder.Entity("Prodaja_Softvera_ver3.Data.EntityModels.Narudzba", b =>
                {
                    b.Property<int>("NarudzbaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Datum_narudzbe")
                        .HasColumnType("datetime2");

                    b.Property<int>("KlijentID")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RacunID")
                        .HasColumnType("int");

                    b.HasKey("NarudzbaID");

                    b.HasIndex("KlijentID");

                    b.HasIndex("RacunID");

                    b.ToTable("Narudzba");
                });

            modelBuilder.Entity("Prodaja_Softvera_ver3.Data.EntityModels.Ocjena", b =>
                {
                    b.Property<int>("OcjenaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("komentar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ocjena")
                        .HasColumnType("float");

                    b.HasKey("OcjenaID");

                    b.ToTable("Ocjena");
                });

            modelBuilder.Entity("Prodaja_Softvera_ver3.Data.EntityModels.Racun", b =>
                {
                    b.Property<int>("RacunID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Cijena")
                        .HasColumnType("float");

                    b.Property<string>("Datum")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RacunID");

                    b.ToTable("Racun");
                });

            modelBuilder.Entity("Prodaja_Softvera_ver3.Data.EntityModels.Softver", b =>
                {
                    b.Property<int>("SoftverID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Cijena")
                        .HasColumnType("float");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SpecifikacijeID")
                        .HasColumnType("int");

                    b.Property<int>("TipSoftveraID")
                        .HasColumnType("int");

                    b.Property<string>("Verzija")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SoftverID");

                    b.HasIndex("SpecifikacijeID");

                    b.HasIndex("TipSoftveraID");

                    b.ToTable("Softver");
                });

            modelBuilder.Entity("Prodaja_Softvera_ver3.Data.EntityModels.SoftverNarudzba", b =>
                {
                    b.Property<int>("SoftverNarudzbaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<int>("Kolicina")
                        .HasColumnType("int");

                    b.Property<int>("NarudzbaID")
                        .HasColumnType("int");

                    b.Property<int>("OcjenaID")
                        .HasColumnType("int");

                    b.Property<int>("SoftverID")
                        .HasColumnType("int");

                    b.HasKey("SoftverNarudzbaID");

                    b.HasIndex("NarudzbaID");

                    b.HasIndex("OcjenaID");

                    b.HasIndex("SoftverID");

                    b.ToTable("SoftverNarudzba");
                });

            modelBuilder.Entity("Prodaja_Softvera_ver3.Data.EntityModels.Specifikacije", b =>
                {
                    b.Property<int>("SpecifikacijeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CPU")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GPU")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HDD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RAM")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SpecifikacijeID");

                    b.ToTable("Specifikacije");
                });

            modelBuilder.Entity("Prodaja_Softvera_ver3.Data.EntityModels.TipSoftvera", b =>
                {
                    b.Property<int>("TipSoftveraID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TipSoftveraID");

                    b.ToTable("TipSoftvera");
                });

            modelBuilder.Entity("Prodaja_Softvera_ver3.Data.EntityModels.TipZaposlenika", b =>
                {
                    b.Property<int>("TipZaposlenikaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TipZaposlenikaID");

                    b.ToTable("TipZaposlenika");
                });

            modelBuilder.Entity("Prodaja_Softvera_ver3.Data.EntityModels.Zaposlenik", b =>
                {
                    b.Property<int>("ZaposlenikID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Datum_rodjenja")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FakultetID")
                        .HasColumnType("int");

                    b.Property<int>("GradID")
                        .HasColumnType("int");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kontakt_br")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("KorisnickiNalogID")
                        .HasColumnType("int");

                    b.Property<string>("Prezime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipZaposlenikaID")
                        .HasColumnType("int");

                    b.HasKey("ZaposlenikID");

                    b.HasIndex("FakultetID");

                    b.HasIndex("GradID");

                    b.HasIndex("KorisnickiNalogID");

                    b.HasIndex("TipZaposlenikaID");

                    b.ToTable("Zaposlenik");
                });

            modelBuilder.Entity("Prodaja_Softvera_ver3.Data.EntityModels.Analiza", b =>
                {
                    b.HasOne("Prodaja_Softvera_ver3.Data.EntityModels.Klijent", "Klijent")
                        .WithMany()
                        .HasForeignKey("KlijentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Prodaja_Softvera_ver3.Data.EntityModels.Softver", "Softver")
                        .WithMany()
                        .HasForeignKey("SoftverID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Prodaja_Softvera_ver3.Data.EntityModels.Zaposlenik", "Zaposlenik")
                        .WithMany()
                        .HasForeignKey("ZaposlenikID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Prodaja_Softvera_ver3.Data.EntityModels.AutorizacijskiToken", b =>
                {
                    b.HasOne("Prodaja_Softvera_ver3.Data.EntityModels.KorisnickiNalog", "KorisnickiNalog")
                        .WithMany()
                        .HasForeignKey("KorisnickiNalogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Prodaja_Softvera_ver3.Data.EntityModels.Grad", b =>
                {
                    b.HasOne("Prodaja_Softvera_ver3.Data.EntityModels.Drzava", "Drzava")
                        .WithMany()
                        .HasForeignKey("DrzavaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Prodaja_Softvera_ver3.Data.EntityModels.Klijent", b =>
                {
                    b.HasOne("Prodaja_Softvera_ver3.Data.EntityModels.Grad", "Grad")
                        .WithMany()
                        .HasForeignKey("GradID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Prodaja_Softvera_ver3.Data.EntityModels.Kartica", "Kartica")
                        .WithMany()
                        .HasForeignKey("KarticaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Prodaja_Softvera_ver3.Data.EntityModels.KorisnickiNalog", "KorisnickiNalog")
                        .WithMany()
                        .HasForeignKey("KorisnickiNalogID");
                });

            modelBuilder.Entity("Prodaja_Softvera_ver3.Data.EntityModels.Narudzba", b =>
                {
                    b.HasOne("Prodaja_Softvera_ver3.Data.EntityModels.Klijent", "Klijent")
                        .WithMany()
                        .HasForeignKey("KlijentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Prodaja_Softvera_ver3.Data.EntityModels.Racun", "Racun")
                        .WithMany()
                        .HasForeignKey("RacunID");
                });

            modelBuilder.Entity("Prodaja_Softvera_ver3.Data.EntityModels.Softver", b =>
                {
                    b.HasOne("Prodaja_Softvera_ver3.Data.EntityModels.Specifikacije", "Specifikacije")
                        .WithMany()
                        .HasForeignKey("SpecifikacijeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Prodaja_Softvera_ver3.Data.EntityModels.TipSoftvera", "TipSoftvera")
                        .WithMany()
                        .HasForeignKey("TipSoftveraID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Prodaja_Softvera_ver3.Data.EntityModels.SoftverNarudzba", b =>
                {
                    b.HasOne("Prodaja_Softvera_ver3.Data.EntityModels.Narudzba", "Narudzba")
                        .WithMany()
                        .HasForeignKey("NarudzbaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Prodaja_Softvera_ver3.Data.EntityModels.Ocjena", "Ocjena")
                        .WithMany()
                        .HasForeignKey("OcjenaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Prodaja_Softvera_ver3.Data.EntityModels.Softver", "Softver")
                        .WithMany()
                        .HasForeignKey("SoftverID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Prodaja_Softvera_ver3.Data.EntityModels.Zaposlenik", b =>
                {
                    b.HasOne("Prodaja_Softvera_ver3.Data.EntityModels.Fakultet", "Fakultet")
                        .WithMany()
                        .HasForeignKey("FakultetID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Prodaja_Softvera_ver3.Data.EntityModels.Grad", "Grad")
                        .WithMany()
                        .HasForeignKey("GradID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Prodaja_Softvera_ver3.Data.EntityModels.KorisnickiNalog", "KorisnickiNalog")
                        .WithMany()
                        .HasForeignKey("KorisnickiNalogID");

                    b.HasOne("Prodaja_Softvera_ver3.Data.EntityModels.TipZaposlenika", "TipZaposlenika")
                        .WithMany()
                        .HasForeignKey("TipZaposlenikaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
