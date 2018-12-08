using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace site
{
    public partial class teslaContext : DbContext
    {
        public teslaContext()
        {
        }

        public teslaContext(DbContextOptions<teslaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Consumer> Consumer { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Item> Item { get; set; }
        public virtual DbSet<Item2sell> Item2sell { get; set; }
        public virtual DbSet<Job> Job { get; set; }
        public virtual DbSet<Part> Part { get; set; }
        public virtual DbSet<Part2item> Part2item { get; set; }
        public virtual DbSet<User2item> User2item { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("Host=localhost;Database=tesla;Username=postgres;Password=password");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Consumer>(entity =>
            {
                entity.HasKey(e => e.Email);

                entity.ToTable("consumer");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(200)
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnName("address")
                    .HasMaxLength(500);

                entity.Property(e => e.Nama)
                    .IsRequired()
                    .HasColumnName("nama")
                    .HasMaxLength(200);

                entity.Property(e => e.Notel).HasColumnName("notel");

                entity.Property(e => e.Pass)
                    .IsRequired()
                    .HasColumnName("pass")
                    .HasMaxLength(200);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.Email);

                entity.ToTable("employee");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(200)
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnName("address")
                    .HasMaxLength(500);

                entity.Property(e => e.Lastlogin)
                    .HasColumnName("lastlogin")
                    .HasColumnType("date");

                entity.Property(e => e.Nama)
                    .IsRequired()
                    .HasColumnName("nama")
                    .HasMaxLength(200);

                entity.Property(e => e.Notel).HasColumnName("notel");

                entity.Property(e => e.Pass)
                    .IsRequired()
                    .HasColumnName("pass")
                    .HasMaxLength(200);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Item>(entity =>
            {
                entity.HasKey(e => e.Itemno);

                entity.ToTable("item");

                entity.Property(e => e.Itemno).HasColumnName("itemno");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(500);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(200);

                entity.Property(e => e.Imgurl)
                    .HasColumnName("imgurl")
                    .HasMaxLength(500);

                entity.Property(e => e.Item2sellno).HasColumnName("item2sellno");

                entity.Property(e => e.Jobid).HasColumnName("jobid");

                entity.HasOne(d => d.EmailNavigation)
                    .WithMany(p => p.Item)
                    .HasForeignKey(d => d.Email)
                    .HasConstraintName("item_consumer_fk");

                entity.HasOne(d => d.Item2sell)
                    .WithMany(p => p.Item)
                    .HasForeignKey(d => d.Item2sellno)
                    .HasConstraintName("item_item2sell_fk");

                entity.HasOne(d => d.Job)
                    .WithOne(p => p.Item)
                    .HasForeignKey<Item>(d => d.Jobid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkey_jobid_job");
            });

            modelBuilder.Entity<Item2sell>(entity =>
            {
                entity.HasKey(e => e.Item2sellno);

                entity.ToTable("item2sell");

                entity.Property(e => e.Item2sellno)
                    .HasColumnName("item2sellno")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("character varying");

                entity.Property(e => e.Harga)
                    .HasColumnName("harga")
                    .HasColumnType("character varying");

                entity.Property(e => e.Imgurl)
                    .HasColumnName("imgurl")
                    .HasColumnType("character varying");

                entity.Property(e => e.Namamobil)
                    .HasColumnName("namamobil")
                    .HasColumnType("character varying");

                entity.Property(e => e.Warna)
                    .HasColumnName("warna")
                    .HasColumnType("character varying");
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.ToTable("job");

                entity.Property(e => e.Jobid)
                    .HasColumnName("jobid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Employeeemail)
                    .IsRequired()
                    .HasColumnName("employeeemail")
                    .HasMaxLength(200);

                entity.Property(e => e.Lastupdated).HasColumnName("lastupdated");

                entity.Property(e => e.Progress)
                    .IsRequired()
                    .HasColumnName("progress")
                    .HasMaxLength(500);

                entity.HasOne(d => d.EmployeeemailNavigation)
                    .WithMany(p => p.Job)
                    .HasForeignKey(d => d.Employeeemail)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkey_employeeemail_employee");
            });

            modelBuilder.Entity<Part>(entity =>
            {
                entity.HasKey(e => e.Itemno);

                entity.ToTable("part");

                entity.Property(e => e.Itemno).HasColumnName("itemno");

                entity.Property(e => e.Harga).HasColumnName("harga");

                entity.Property(e => e.Namapart)
                    .IsRequired()
                    .HasColumnName("namapart")
                    .HasMaxLength(200);

                entity.Property(e => e.Qty).HasColumnName("qty");
            });

            modelBuilder.Entity<Part2item>(entity =>
            {
                entity.HasKey(e => e.No);

                entity.ToTable("part2item");

                entity.Property(e => e.No).HasColumnName("no");

                entity.Property(e => e.Itemnoitem).HasColumnName("itemnoitem");

                entity.Property(e => e.Itemnopart).HasColumnName("itemnopart");

                entity.HasOne(d => d.Item2sellNavigation)
                    .WithMany(p => p.Part2item)
                    .HasForeignKey(d => d.Itemnoitem)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("part2item_item2sell_fk");

                entity.HasOne(d => d.Part)
                    .WithMany(p => p.Part2item)
                    .HasForeignKey(d => d.Itemnopart)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("part2item_part_fk");
            });

            modelBuilder.Entity<User2item>(entity =>
            {
                entity.HasKey(e => e.No);

                entity.ToTable("user2item");

                entity.Property(e => e.No).HasColumnName("no");

                entity.Property(e => e.Emailuser)
                    .IsRequired()
                    .HasColumnName("emailuser")
                    .HasMaxLength(200);

                entity.Property(e => e.Itemno).HasColumnName("itemno");

                entity.HasOne(d => d.EmailuserNavigation)
                    .WithMany(p => p.User2item)
                    .HasForeignKey(d => d.Emailuser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkey_email_user");

                entity.HasOne(d => d.ItemnoNavigation)
                    .WithMany(p => p.User2item)
                    .HasForeignKey(d => d.Itemno)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fkey_item_itemno");
            });

            modelBuilder.HasSequence("item_itemno_seq");

            modelBuilder.HasSequence("part_itemno_seq");

            modelBuilder.HasSequence("part2item_no_seq");

            modelBuilder.HasSequence("tipemobil_tipeno_seq");

            modelBuilder.HasSequence("user2item_no_seq");
        }
    }
}
