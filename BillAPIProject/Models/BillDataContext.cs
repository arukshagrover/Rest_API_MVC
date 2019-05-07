using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BillAPIProject.Models
{
    public partial class BillDataContext : DbContext
    {
        public BillDataContext()
        {
        }

        public BillDataContext(DbContextOptions<BillDataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Table1> Table1 { get; set; }
        public virtual DbSet<Table2> Table2 { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=MSIT-SAWAR\\SQLEXPRESS;Database=BillData;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Table1>(entity =>
            {
                entity.HasKey(e => e.SubscriptionId);

                entity.Property(e => e.SubscriptionId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.BillingCycleType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChargeEndDate).HasColumnType("date");

                entity.Property(e => e.ChargeStartDate).HasColumnType("date");

                entity.Property(e => e.ChargeType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Currency)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DomainName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DurableOfferId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MpnId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OfferId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OfferName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PartnerId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Quantity).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.SubscriptionDescription)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SubscriptionEndDate).HasColumnType("date");

                entity.Property(e => e.SubscriptionName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SubscriptionStartDate).HasColumnType("date");

                entity.Property(e => e.SyndicationPartnerSubscriptionNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Table2>(entity =>
            {
                entity.HasKey(e => e.Row);

                entity.Property(e => e.Row).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.BillingCycleType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChargeEndDate).HasColumnType("date");

                entity.Property(e => e.ChargeStartDate).HasColumnType("date");

                entity.Property(e => e.ChargeType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Currency)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerCompanyName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DetailLineItemId).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.DomainName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceNumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MpnId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrderId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PartnerBillableAccountId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PartnerId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PartnerName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Region)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ResourceGuid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ResourceName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sku)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubscriptionDescription)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SubscriptionId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubscriptionName)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Unit)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
