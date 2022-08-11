using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Configuration;

#nullable disable

namespace BusinessObject
{
    public partial class Hostel_Management_ProjectContext : DbContext
    {
        public Hostel_Management_ProjectContext()
        {

        }

        public Hostel_Management_ProjectContext(DbContextOptions<Hostel_Management_ProjectContext> options)
            : base(options)
        {

        }

        public virtual DbSet<Contract> Contracts { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Equipment> Equipment { get; set; }
        public virtual DbSet<HostelOwner> HostelOwners { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<UsedService> UsedServices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server =(local); Database = Hostel_Management_Project; Uid=sa; Pwd=123;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Contract>(entity =>
            {
                entity.ToTable("Contract");

                entity.Property(e => e.ContractId).HasColumnName("contractID");

                entity.Property(e => e.CustomerId).HasColumnName("customerID");

                entity.Property(e => e.DepositMoney).HasColumnName("depositMoney");

                entity.Property(e => e.DepositMoneyStatus).HasColumnName("depositMoneyStatus");

                entity.Property(e => e.EndDate)
                    .HasColumnType("date")
                    .HasColumnName("endDate");

                entity.Property(e => e.RoomId).HasColumnName("roomID");

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasColumnName("startDate");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Contracts)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractCustomer");

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.Contracts)
                    .HasForeignKey(d => d.RoomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContractRoom");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.Property(e => e.CustomerId).HasColumnName("customerID");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(50)
                    .HasColumnName("customerName");

                entity.Property(e => e.Dob)
                    .HasColumnType("date")
                    .HasColumnName("dob");

                entity.Property(e => e.DocumentId)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("documentID")
                    .IsFixedLength(true);

                entity.Property(e => e.Gender)
                    .HasMaxLength(50)
                    .HasColumnName("gender");

                entity.Property(e => e.IsRenting).HasColumnName("isRenting");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("phoneNumber")
                    .IsFixedLength(true);

                entity.Property(e => e.RoomId).HasColumnName("roomId");

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.RoomId)
                    .HasConstraintName("FK_CustomerRoom");
            });

            modelBuilder.Entity<Equipment>(entity =>
            {
                entity.Property(e => e.EquipmentId).HasColumnName("equipmentID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.RoomId).HasColumnName("roomID");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.Equipment)
                    .HasForeignKey(d => d.RoomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EquipmentRoom");
            });

            modelBuilder.Entity<HostelOwner>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__HostelOw__CB9A1CDF61C80511");

                entity.ToTable("HostelOwner");

                entity.HasIndex(e => e.Username, "UQ__HostelOw__F3DBC572261A35AC")
                    .IsUnique();

                entity.Property(e => e.UserId).HasColumnName("userID");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Username)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.ToTable("Invoice");

                entity.Property(e => e.InvoiceId).HasColumnName("invoiceID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("createDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustomerId).HasColumnName("customerID");

                entity.Property(e => e.InvoiceName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("invoiceName");

                entity.Property(e => e.Note)
                    .HasMaxLength(255)
                    .HasColumnName("note");

                entity.Property(e => e.RoomCharge).HasColumnName("roomCharge");

                entity.Property(e => e.RoomId).HasColumnName("roomID");

                entity.Property(e => e.ServiceCharge).HasColumnName("serviceCharge");

                entity.Property(e => e.Status).HasColumnName("status");

                entity.Property(e => e.Total).HasColumnName("total");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InvoiceCustomer");

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.RoomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InvoiceRoom");
            });

            modelBuilder.Entity<Room>(entity =>
            {
                entity.ToTable("Room");

                entity.Property(e => e.RoomId).HasColumnName("roomID");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.RoomName)
                    .HasMaxLength(50)
                    .HasColumnName("roomName");

                entity.Property(e => e.RoomStatus).HasColumnName("roomStatus");
            });

            modelBuilder.Entity<Service>(entity =>
            {
                entity.ToTable("service");

                entity.Property(e => e.ServiceId).HasColumnName("serviceID");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.ServiceName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("serviceName");
            });

            modelBuilder.Entity<UsedService>(entity =>
            {
                entity.ToTable("usedService");

                entity.Property(e => e.UsedServiceId).HasColumnName("usedServiceID");

                entity.Property(e => e.InvoiceId).HasColumnName("invoiceID");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.RoomId).HasColumnName("roomID");

                entity.Property(e => e.ServiceId).HasColumnName("serviceID");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.UsedServices)
                    .HasForeignKey(d => d.InvoiceId)
                    .HasConstraintName("FK_Service");

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.UsedServices)
                    .HasForeignKey(d => d.RoomId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServiceRoom");

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.UsedServices)
                    .HasForeignKey(d => d.ServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InvoiceService");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
