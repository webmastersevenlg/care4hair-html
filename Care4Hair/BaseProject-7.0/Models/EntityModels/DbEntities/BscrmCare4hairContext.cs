using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BaseProject_7_0.Models.EntityModels.DbEntities;

public partial class BscrmCare4hairContext : DbContext
{
    public BscrmCare4hairContext()
    {
    }

    public BscrmCare4hairContext(DbContextOptions<BscrmCare4hairContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ActiveWebBanner> ActiveWebBanners { get; set; }

    public virtual DbSet<ActiveWebPicture> ActiveWebPictures { get; set; }

    public virtual DbSet<ActiveWebSpecial> ActiveWebSpecials { get; set; }

    public virtual DbSet<ActiveWebSpecialsGroupedWithJoin> ActiveWebSpecialsGroupedWithJoins { get; set; }

    public virtual DbSet<ActiveWebSpecialsWithJoin> ActiveWebSpecialsWithJoins { get; set; }

    public virtual DbSet<ActiveWebSpecialsWithRelation> ActiveWebSpecialsWithRelations { get; set; }

    public virtual DbSet<WebBanner> WebBanners { get; set; }

    public virtual DbSet<WebContactForm> WebContactForms { get; set; }

    public virtual DbSet<WebPicResult> WebPicResults { get; set; }

    public virtual DbSet<WebPicture> WebPictures { get; set; }

    public virtual DbSet<WebPictureResolution> WebPictureResolutions { get; set; }

    public virtual DbSet<WebProcedure> WebProcedures { get; set; }

    public virtual DbSet<WebRelatedDoctor> WebRelatedDoctors { get; set; }

    public virtual DbSet<WebRelatedProcedure> WebRelatedProcedures { get; set; }

    public virtual DbSet<WebRelatedProcedureCategory> WebRelatedProcedureCategories { get; set; }

    public virtual DbSet<WebRelatedProceduresRequiredPhotosPerSession> WebRelatedProceduresRequiredPhotosPerSessions { get; set; }

    public virtual DbSet<WebSpecial> WebSpecials { get; set; }

    public virtual DbSet<WebSpecialsGroupedWithJoin> WebSpecialsGroupedWithJoins { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=sql.savvyhawk.net;Database=bscrm-care4hair; user=sa; password=staff7811/*-; Trusted_Connection=false;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ActiveWebBanner>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ActiveWebBanner");

            entity.Property(e => e.BannerName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.DtCreated)
                .HasColumnType("smalldatetime")
                .HasColumnName("dtCreated");
            entity.Property(e => e.DtUpdated)
                .HasColumnType("smalldatetime")
                .HasColumnName("dtUpdated");
            entity.Property(e => e.LargeImageEn)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("LargeImageEN");
            entity.Property(e => e.LargeImageEs)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("LargeImageES");
            entity.Property(e => e.MediumImageEn)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("MediumImageEN");
            entity.Property(e => e.MediumImageEs)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("MediumImageES");
            entity.Property(e => e.RunFrom).HasColumnType("smalldatetime");
            entity.Property(e => e.RunUntil).HasColumnType("smalldatetime");
            entity.Property(e => e.SmallImageEn)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SmallImageEN");
            entity.Property(e => e.SmallImageEs)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SmallImageES");
            entity.Property(e => e.Urlen)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("URLEN");
            entity.Property(e => e.Urles)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("URLES");
            entity.Property(e => e.WebBannerId)
                .ValueGeneratedOnAdd()
                .HasColumnName("WebBannerID");
        });

        modelBuilder.Entity<ActiveWebPicture>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ActiveWebPictures");

            entity.Property(e => e.PatientId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PatientID");
            entity.Property(e => e.PictureFileName)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.PictureTitle)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.ProfessionalImageName).HasMaxLength(50);
            entity.Property(e => e.ProfessionalName).HasMaxLength(50);
            entity.Property(e => e.ProfessionalUrl).HasMaxLength(50);
            entity.Property(e => e.ServiceName).HasMaxLength(100);
            entity.Property(e => e.ServiceUrl).HasMaxLength(100);
            entity.Property(e => e.Title)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.WebPicResultId).HasColumnName("WebPicResultID");
            entity.Property(e => e.WebPictureId).HasColumnName("WebPictureID");
        });

        modelBuilder.Entity<ActiveWebSpecial>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ActiveWebSpecials");

            entity.Property(e => e.ContactFormEn).HasColumnName("ContactFormEN");
            entity.Property(e => e.ContactFormEs).HasColumnName("ContactFormES");
            entity.Property(e => e.DetailEn)
                .HasMaxLength(5000)
                .IsUnicode(false)
                .HasColumnName("DetailEN");
            entity.Property(e => e.DetailEs)
                .HasMaxLength(5000)
                .IsUnicode(false)
                .HasColumnName("DetailES");
            entity.Property(e => e.DtCreated)
                .HasColumnType("smalldatetime")
                .HasColumnName("dtCreated");
            entity.Property(e => e.DtUpdated)
                .HasColumnType("smalldatetime")
                .HasColumnName("dtUpdated");
            entity.Property(e => e.LargeImageEn)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("LargeImageEN");
            entity.Property(e => e.LargeImageEs)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("LargeImageES");
            entity.Property(e => e.NameEn)
                .HasMaxLength(55)
                .IsUnicode(false)
                .HasColumnName("NameEN");
            entity.Property(e => e.NameEs)
                .HasMaxLength(55)
                .IsUnicode(false)
                .HasColumnName("NameES");
            entity.Property(e => e.RunFrom).HasColumnType("smalldatetime");
            entity.Property(e => e.RunUntil).HasColumnType("smalldatetime");
            entity.Property(e => e.SmallImageEn)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SmallImageEN");
            entity.Property(e => e.SmallImageEs)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SmallImageES");
            entity.Property(e => e.Urlen)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("URLEN");
            entity.Property(e => e.Urles)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("URLES");
            entity.Property(e => e.WebContactFormId).HasColumnName("WebContactFormID");
            entity.Property(e => e.WebRelatedProcedures).HasMaxLength(100);
            entity.Property(e => e.WebScontactFormName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("WebSContactFormName");
        });

        modelBuilder.Entity<ActiveWebSpecialsGroupedWithJoin>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ActiveWebSpecialsGroupedWithJoins");

            entity.Property(e => e.WebRelatedDoctors).HasMaxLength(102);
            entity.Property(e => e.WebRelatedProcedureCategories).HasMaxLength(102);
            entity.Property(e => e.WebRelatedProcedures).HasMaxLength(202);
        });

        modelBuilder.Entity<ActiveWebSpecialsWithJoin>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ActiveWebSpecialsWithJoins");

            entity.Property(e => e.ContactFormEn).HasColumnName("ContactFormEN");
            entity.Property(e => e.ContactFormEs).HasColumnName("ContactFormES");
            entity.Property(e => e.DetailEn)
                .HasMaxLength(5000)
                .IsUnicode(false)
                .HasColumnName("DetailEN");
            entity.Property(e => e.DetailEs)
                .HasMaxLength(5000)
                .IsUnicode(false)
                .HasColumnName("DetailES");
            entity.Property(e => e.DtCreated)
                .HasColumnType("smalldatetime")
                .HasColumnName("dtCreated");
            entity.Property(e => e.DtUpdated)
                .HasColumnType("smalldatetime")
                .HasColumnName("dtUpdated");
            entity.Property(e => e.Expr2).HasMaxLength(50);
            entity.Property(e => e.Expr3).HasMaxLength(50);
            entity.Property(e => e.LargeImageEn)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("LargeImageEN");
            entity.Property(e => e.LargeImageEs)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("LargeImageES");
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.NameEn)
                .HasMaxLength(55)
                .IsUnicode(false)
                .HasColumnName("NameEN");
            entity.Property(e => e.NameEs)
                .HasMaxLength(55)
                .IsUnicode(false)
                .HasColumnName("NameES");
            entity.Property(e => e.RunFrom).HasColumnType("smalldatetime");
            entity.Property(e => e.RunUntil).HasColumnType("smalldatetime");
            entity.Property(e => e.SmallImageEn)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SmallImageEN");
            entity.Property(e => e.SmallImageEs)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SmallImageES");
            entity.Property(e => e.UrlSection).HasMaxLength(100);
            entity.Property(e => e.Urlen)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("URLEN");
            entity.Property(e => e.Urles)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("URLES");
            entity.Property(e => e.WebContactFormId).HasColumnName("WebContactFormID");
            entity.Property(e => e.WebScontactFormName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("WebSContactFormName");
            entity.Property(e => e.WebSpecialId).HasColumnName("WebSpecialID");
        });

        modelBuilder.Entity<ActiveWebSpecialsWithRelation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ActiveWebSpecialsWithRelations");

            entity.Property(e => e.Category).HasMaxLength(50);
            entity.Property(e => e.ContactFormEn).HasColumnName("ContactFormEN");
            entity.Property(e => e.ContactFormEs).HasColumnName("ContactFormES");
            entity.Property(e => e.DetailEn)
                .HasMaxLength(5000)
                .IsUnicode(false)
                .HasColumnName("DetailEN");
            entity.Property(e => e.DetailEs)
                .HasMaxLength(5000)
                .IsUnicode(false)
                .HasColumnName("DetailES");
            entity.Property(e => e.Doctor).HasMaxLength(50);
            entity.Property(e => e.DtCreated)
                .HasColumnType("smalldatetime")
                .HasColumnName("dtCreated");
            entity.Property(e => e.DtUpdated)
                .HasColumnType("smalldatetime")
                .HasColumnName("dtUpdated");
            entity.Property(e => e.LargeImageEn)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("LargeImageEN");
            entity.Property(e => e.LargeImageEs)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("LargeImageES");
            entity.Property(e => e.NameEn)
                .HasMaxLength(55)
                .IsUnicode(false)
                .HasColumnName("NameEN");
            entity.Property(e => e.NameEs)
                .HasMaxLength(55)
                .IsUnicode(false)
                .HasColumnName("NameES");
            entity.Property(e => e.Procedure).HasMaxLength(100);
            entity.Property(e => e.RunFrom).HasColumnType("smalldatetime");
            entity.Property(e => e.RunUntil).HasColumnType("smalldatetime");
            entity.Property(e => e.SmallImageEn)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SmallImageEN");
            entity.Property(e => e.SmallImageEs)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SmallImageES");
            entity.Property(e => e.Urlen)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("URLEN");
            entity.Property(e => e.Urles)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("URLES");
        });

        modelBuilder.Entity<WebBanner>(entity =>
        {
            entity.Property(e => e.BannerName)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.DtCreated)
                .HasColumnType("smalldatetime")
                .HasColumnName("dtCreated");
            entity.Property(e => e.DtUpdated)
                .HasColumnType("smalldatetime")
                .HasColumnName("dtUpdated");
            entity.Property(e => e.LargeImageEn)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("LargeImageEN");
            entity.Property(e => e.LargeImageEs)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("LargeImageES");
            entity.Property(e => e.MediumImageEn)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("MediumImageEN");
            entity.Property(e => e.MediumImageEs)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("MediumImageES");
            entity.Property(e => e.RunFrom).HasColumnType("smalldatetime");
            entity.Property(e => e.RunUntil).HasColumnType("smalldatetime");
            entity.Property(e => e.SmallImageEn)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SmallImageEN");
            entity.Property(e => e.SmallImageEs)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SmallImageES");
            entity.Property(e => e.Urlen)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("URLEN");
            entity.Property(e => e.Urles)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("URLES");
        });

        modelBuilder.Entity<WebContactForm>(entity =>
        {
            entity.Property(e => e.WebContactFormId).HasColumnName("WebContactFormID");
            entity.Property(e => e.WebScontactFormName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("WebSContactFormName");
        });

        modelBuilder.Entity<WebPicResult>(entity =>
        {
            entity.Property(e => e.WebPicResultId).HasColumnName("WebPicResultID");
            entity.Property(e => e.DtModified)
                .HasColumnType("smalldatetime")
                .HasColumnName("dtModified");
            entity.Property(e => e.PatientId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("PatientID");
            entity.Property(e => e.PictureConsent).HasDefaultValueSql("((0))");
            entity.Property(e => e.Priority).HasDefaultValueSql("((0))");
            entity.Property(e => e.StaffId).HasColumnName("StaffID");
            entity.Property(e => e.Title)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.HasOne(d => d.Staff).WithMany(p => p.WebPicResults)
                .HasForeignKey(d => d.StaffId)
                .HasConstraintName("FK_WebPicResults_WebRelatedDoctors");
        });

        modelBuilder.Entity<WebPicture>(entity =>
        {
            entity.Property(e => e.WebPictureId).HasColumnName("WebPictureID");
            entity.Property(e => e.DtModified)
                .HasColumnType("smalldatetime")
                .HasColumnName("dtModified");
            entity.Property(e => e.Name)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Title)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.WebPicResultId).HasColumnName("WebPicResultID");
        });

        modelBuilder.Entity<WebPictureResolution>(entity =>
        {
            entity.Property(e => e.WebPictureResolutionId).HasColumnName("WebPictureResolutionID");
            entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");
            entity.Property(e => e.WebPictureResolutionName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WebProcedure>(entity =>
        {
            entity.HasKey(e => e.WebProceduresId);

            entity.Property(e => e.WebProceduresId).HasColumnName("WebProceduresID");
            entity.Property(e => e.WebProceduresName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<WebRelatedDoctor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.RelatedDoctors");

            entity.Property(e => e.Active).HasDefaultValueSql("((1))");
            entity.Property(e => e.Avatar).HasMaxLength(50);
            entity.Property(e => e.FullName).HasMaxLength(50);
            entity.Property(e => e.UrlSection).HasMaxLength(50);
        });

        modelBuilder.Entity<WebRelatedProcedure>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_dbo.RelatedProcedures");

            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.NameSpanish).HasMaxLength(100);
            entity.Property(e => e.UrlSection).HasMaxLength(100);
            entity.Property(e => e.UrlSectionSpanish).HasMaxLength(100);

            entity.HasOne(d => d.WebRelatedProcedureCategory).WithMany(p => p.WebRelatedProcedures)
                .HasForeignKey(d => d.WebRelatedProcedureCategoryId)
                .HasConstraintName("FK_WebRelatedProcedures_WebRelatedProcedureCategory");
        });

        modelBuilder.Entity<WebRelatedProcedureCategory>(entity =>
        {
            entity.ToTable("WebRelatedProcedureCategory");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.UrlSection).HasMaxLength(50);
        });

        modelBuilder.Entity<WebRelatedProceduresRequiredPhotosPerSession>(entity =>
        {
            entity.HasKey(e => new { e.WebRelatedProcedureId, e.RequiredPhotosPerSession });

            entity.ToTable("WebRelatedProceduresRequiredPhotosPerSession");

            entity.HasOne(d => d.WebRelatedProcedure).WithMany(p => p.WebRelatedProceduresRequiredPhotosPerSessions)
                .HasForeignKey(d => d.WebRelatedProcedureId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_WebRelatedProceduresRequiredPhotosPerSession_WebRelatedProceduresRequiredPhotosPerSession");
        });

        modelBuilder.Entity<WebSpecial>(entity =>
        {
            entity.Property(e => e.ContactFormEn).HasColumnName("ContactFormEN");
            entity.Property(e => e.ContactFormEs).HasColumnName("ContactFormES");
            entity.Property(e => e.DetailEn)
                .HasMaxLength(5000)
                .IsUnicode(false)
                .HasColumnName("DetailEN");
            entity.Property(e => e.DetailEs)
                .HasMaxLength(5000)
                .IsUnicode(false)
                .HasColumnName("DetailES");
            entity.Property(e => e.Discount).HasColumnType("money");
            entity.Property(e => e.DtCreated)
                .HasColumnType("smalldatetime")
                .HasColumnName("dtCreated");
            entity.Property(e => e.DtUpdated)
                .HasColumnType("smalldatetime")
                .HasColumnName("dtUpdated");
            entity.Property(e => e.Includes)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.IncludesEs)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("IncludesES");
            entity.Property(e => e.LargeImageEn)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("LargeImageEN");
            entity.Property(e => e.LargeImageEncensored)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("LargeImageENCensored");
            entity.Property(e => e.LargeImageEs)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("LargeImageES");
            entity.Property(e => e.LargeImageEscensored)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("LargeImageESCensored");
            entity.Property(e => e.NameEn)
                .HasMaxLength(55)
                .IsUnicode(false)
                .HasColumnName("NameEN");
            entity.Property(e => e.NameEs)
                .HasMaxLength(55)
                .IsUnicode(false)
                .HasColumnName("NameES");
            entity.Property(e => e.Price).HasColumnType("money");
            entity.Property(e => e.RunFrom).HasColumnType("smalldatetime");
            entity.Property(e => e.RunUntil).HasColumnType("smalldatetime");
            entity.Property(e => e.SmallImageEn)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SmallImageEN");
            entity.Property(e => e.SmallImageEncensored)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SmallImageENCensored");
            entity.Property(e => e.SmallImageEs)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SmallImageES");
            entity.Property(e => e.SmallImageEscensored)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("SmallImageESCensored");
            entity.Property(e => e.Urlen)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("URLEN");
            entity.Property(e => e.Urles)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("URLES");

            entity.HasOne(d => d.ContactFormEnNavigation).WithMany(p => p.WebSpecialContactFormEnNavigations)
                .HasForeignKey(d => d.ContactFormEn)
                .HasConstraintName("FK_WebSpecials_WebContactForms");

            entity.HasOne(d => d.ContactFormEsNavigation).WithMany(p => p.WebSpecialContactFormEsNavigations)
                .HasForeignKey(d => d.ContactFormEs)
                .HasConstraintName("FK_WebSpecials_WebContactForms1");

            entity.HasMany(d => d.WebRelatedDoctors).WithMany(p => p.WebSpecials)
                .UsingEntity<Dictionary<string, object>>(
                    "WebSpecialDoctors",
                    r => r.HasOne<WebRelatedDoctor>().WithMany()
                        .HasForeignKey("WebRelatedDoctorId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_WebEspecialDoctors_WebRelatedDoctors"),
                    l => l.HasOne<WebSpecial>().WithMany()
                        .HasForeignKey("WebSpecialId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_WebSpecialDoctors_WebSpecials"),
                    j =>
                    {
                        j.HasKey("WebSpecialId", "WebRelatedDoctorId").HasName("PK_WebEspecialDoctors");
                    });

            entity.HasMany(d => d.WebRelatedProcedures).WithMany(p => p.WebSpecials)
                .UsingEntity<Dictionary<string, object>>(
                    "WebSpecialProcedures",
                    r => r.HasOne<WebRelatedProcedure>().WithMany()
                        .HasForeignKey("WebRelatedProcedureId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_WebSpecialProcedures_WebRelatedProcedures"),
                    l => l.HasOne<WebSpecial>().WithMany()
                        .HasForeignKey("WebSpecialId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_WebSpecialProcedures_WebSpecials"),
                    j =>
                    {
                        j.HasKey("WebSpecialId", "WebRelatedProcedureId").HasName("PK_WebEspecialProcedures");
                    });
        });

        modelBuilder.Entity<WebSpecialsGroupedWithJoin>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("WebSpecialsGroupedWithJoins");

            entity.Property(e => e.WebRelatedDoctor).HasMaxLength(102);
            entity.Property(e => e.WebRelatedProcedure).HasMaxLength(202);
            entity.Property(e => e.WebRelatedProcedureCategory).HasMaxLength(102);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
