using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DB2Backend.Models;

public partial class Db2Context : DbContext
{
    public Db2Context()
    {
    }

    public Db2Context(DbContextOptions<Db2Context> options)
        : base(options)
    {
    }

    public DbSet<procentPlciModel> procentPlci { get;set; }
    public virtual DbSet<AdresZamieszkanium> AdresZamieszkania { get; set; }

    public virtual DbSet<Jezyk> Jezyks { get; set; }

    public virtual DbSet<JezykObywatel> JezykObywatels { get; set; }

    public virtual DbSet<KontoPortalu> KontoPortalus { get; set; }

    public virtual DbSet<Obywatel> Obywatels { get; set; }

    public virtual DbSet<Obywatelstwo> Obywatelstwos { get; set; }

    public virtual DbSet<ObywatelstwoObywatel> ObywatelstwoObywatels { get; set; }

    public virtual DbSet<Plec> Plecs { get; set; }

    public virtual DbSet<Wojewodztwo> Wojewodztwos { get; set; }

    public virtual DbSet<Wyksztalcenie> Wyksztalcenies { get; set; }

    public virtual DbSet<WyksztalcenieObywatel> WyksztalcenieObywatels { get; set; }

    public virtual DbSet<Zgloszenium> Zgloszenia { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=RFWANB125\\YARIDSQL;Database=DB2;Trusted_Connection=True; Encrypt = False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<procentPlciModel>().HasNoKey();

        modelBuilder.Entity<AdresZamieszkanium>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Adres_za__3214EC27D54C5823");

            entity.ToTable("Adres_zamieszkania");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Kraj)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Miasto)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.NrDomu).HasColumnName("Nr_domu");
            entity.Property(e => e.NrMieszkania).HasColumnName("Nr_mieszkania");
            entity.Property(e => e.Ulica)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Jezyk>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Jezyk__3214EC27DB44EEB0");

            entity.ToTable("Jezyk");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CzyOjczysty).HasColumnName("Czy_ojczysty");
            entity.Property(e => e.Nazwa)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<JezykObywatel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Jezyk_Ob__3214EC276793DFE9");

            entity.ToTable("Jezyk_Obywatel");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.JezykId).HasColumnName("JezykID");
            entity.Property(e => e.ObywatelId).HasColumnName("ObywatelID");

            entity.HasOne(d => d.Jezyk).WithMany(p => p.JezykObywatels)
                .HasForeignKey(d => d.JezykId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Jezyk_Oby__Jezyk__0682EC34");

            entity.HasOne(d => d.Obywatel).WithMany(p => p.JezykObywatels)
                .HasForeignKey(d => d.ObywatelId)
                .HasConstraintName("FK__Jezyk_Oby__Obywa__0E240DFC");
        });

        modelBuilder.Entity<KontoPortalu>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Konto_po__3214EC2733DB538D");

            entity.ToTable("Konto_portalu");

            entity.HasIndex(e => e.Email, "EmailIndex");

            entity.HasIndex(e => e.Email, "UQ__Konto_po__A9D10534788EAC43").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CzyUrzednik).HasColumnName("Czy_urzednik");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Obywatel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Obywatel__3214EC27F47A7D05");

            entity.ToTable("Obywatel", tb =>
                {
                    tb.HasTrigger("TestPESEL_INSUPD");
                    tb.HasTrigger("WYPROWADZKA");
                });

            entity.HasIndex(e => e.Nazwisko, "NazwiskoIndex");

            entity.HasIndex(e => e.Pesel, "PESELIndex");

            entity.HasIndex(e => e.Pesel, "UQ__Obywatel__4F16EE7F967D5771").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AdresZamieszkania).HasColumnName("Adres_zamieszkania");
            entity.Property(e => e.DataUrodzenia)
                .HasColumnType("date")
                .HasColumnName("Data_urodzenia");
            entity.Property(e => e.Imie)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.KontoPortalu).HasColumnName("Konto_portalu");
            entity.Property(e => e.Nazwisko)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.NrDokumentu).HasColumnName("Nr_dokumentu");
            entity.Property(e => e.Pesel)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("PESEL");

            entity.HasOne(d => d.AdresZamieszkaniaNavigation).WithMany(p => p.Obywatels)
                .HasForeignKey(d => d.AdresZamieszkania)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Obywatel__Adres___7C055DC1");

            entity.HasOne(d => d.KontoPortaluNavigation).WithMany(p => p.Obywatels)
                .HasForeignKey(d => d.KontoPortalu)
                .HasConstraintName("FK__Obywatel__Konto___7CF981FA");

            entity.HasOne(d => d.PlecNavigation).WithMany(p => p.Obywatels)
                .HasForeignKey(d => d.Plec)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Obywatel__Plec__7A1D154F");

            entity.HasOne(d => d.WojewodztwoNavigation).WithMany(p => p.Obywatels)
                .HasForeignKey(d => d.Wojewodztwo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Obywatel__Wojewo__7B113988");
        });

        modelBuilder.Entity<Obywatelstwo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Obywatel__3214EC27C2661794");

            entity.ToTable("Obywatelstwo");

            entity.HasIndex(e => e.Nazwa, "ObywatelstwoIndex");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CzyPierwotne).HasColumnName("Czy_pierwotne");
            entity.Property(e => e.Nazwa)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ObywatelstwoObywatel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Obywatel__3214EC279C00FED0");

            entity.ToTable("Obywatelstwo_Obywatel");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ObywatelId).HasColumnName("ObywatelID");
            entity.Property(e => e.ObywatelstwoId).HasColumnName("ObywatelstwoID");

            entity.HasOne(d => d.Obywatel).WithMany(p => p.ObywatelstwoObywatels)
                .HasForeignKey(d => d.ObywatelId)
                .HasConstraintName("FK__Obywatels__Obywa__0F183235");

            entity.HasOne(d => d.Obywatelstwo).WithMany(p => p.ObywatelstwoObywatels)
                .HasForeignKey(d => d.ObywatelstwoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Obywatels__Obywa__0A537D18");
        });

        modelBuilder.Entity<Plec>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Plec__3214EC27A4643CB0");

            entity.ToTable("Plec");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Nazwa)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Wojewodztwo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Wojewodz__3214EC27EB337E56");

            entity.ToTable("Wojewodztwo");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Nazwa)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Wyksztalcenie>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Wyksztal__3214EC27497DC333");

            entity.ToTable("Wyksztalcenie");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Nazwa)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Stopien)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WyksztalcenieObywatel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Wyksztal__3214EC279EE0D164");

            entity.ToTable("Wyksztalcenie_Obywatel");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ObywatelId).HasColumnName("ObywatelID");
            entity.Property(e => e.WyksztalcenieId).HasColumnName("WyksztalcenieID");

            entity.HasOne(d => d.Obywatel).WithMany(p => p.WyksztalcenieObywatels)
                .HasForeignKey(d => d.ObywatelId)
                .HasConstraintName("FK__Wyksztalc__Obywa__0D2FE9C3");

            entity.HasOne(d => d.Wyksztalcenie).WithMany(p => p.WyksztalcenieObywatels)
                .HasForeignKey(d => d.WyksztalcenieId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Wyksztalc__Wyksz__02B25B50");
        });

        modelBuilder.Entity<Zgloszenium>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Zgloszen__3214EC274652C6E5");

            entity.HasIndex(e => e.IdZglaszajacego, "ID_zglaszajacegoIndex");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CzyRozpatrzone).HasColumnName("Czy_rozpatrzone");
            entity.Property(e => e.IdZglaszajacego).HasColumnName("ID_Zglaszajacego");
            entity.Property(e => e.Tresc)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.IdZglaszajacegoNavigation).WithMany(p => p.Zgloszenia)
                .HasForeignKey(d => d.IdZglaszajacego)
                .HasConstraintName("FK__Zgloszeni__ID_Zg__0C3BC58A");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
