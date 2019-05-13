using Microsoft.EntityFrameworkCore;
using Models;
using System;

namespace DAL
{
    public class Context:DbContext
    {
        public Context(DbContextOptions options):base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DoctorSpec>().HasKey(o => new { o.ESSN, o.Spc_Id });
            modelBuilder.Entity<OnlineUser>().HasKey(o => new { o.ConnectionId, o.Usr_Id });
            modelBuilder.Entity<Phone>().HasKey(o => new { o.Number, o.Usr_Id });

            modelBuilder.Entity<Doctor>().Property(a => a.Verified).HasDefaultValue(false);
            modelBuilder.Entity<Doctor>().Property(a => a.Status).HasDefaultValue(false);
            modelBuilder.Entity<User>().Property(a => a.Rate).HasDefaultValue(0);

            modelBuilder
             .Entity<Address>()
             .Property(e => e.Type)
             .HasConversion(
                 v=>v.ToString(),
                 v=> (AddressTypeEnum)Enum.Parse(typeof(AddressTypeEnum), v));

            modelBuilder
             .Entity<Card>()
             .Property(e => e.Card_Type)
             .HasConversion(
                 v => v.ToString(),
                 v => (CardTypeEnum)Enum.Parse(typeof(CardTypeEnum), v));

            modelBuilder
             .Entity<Doctor>()
             .Property(e => e.Degree)
             .HasConversion(
                 v => v.ToString(),
                 v => (DegreeEnum)Enum.Parse(typeof(DegreeEnum), v));

            modelBuilder
             .Entity<User>()
             .Property(e => e.Gender)
             .HasConversion(
                 v => v.ToString(),
                 v => (GenderEnum)Enum.Parse(typeof(GenderEnum), v));

            modelBuilder.Entity<Message>()
            .HasOne(x => x.UserFrom)
            .WithMany(u => u.MessagesFrom)
            .OnDelete(DeleteBehavior.Restrict).IsRequired(true);


            modelBuilder.Entity<Message>()
            .HasOne(x => x.UserTo)
            .WithMany(u => u.MessagesTo)
            .OnDelete(DeleteBehavior.Restrict).IsRequired(true);

            modelBuilder.Entity<Transaction>()
            .HasOne(x => x.Doctor)
            .WithMany(u => u.TransactionsDoctor)
            .OnDelete(DeleteBehavior.Restrict).IsRequired(true);


            modelBuilder.Entity<Transaction>()
            .HasOne(x => x.Patient)
            .WithMany(u => u.TransactionsPatient)
            .OnDelete(DeleteBehavior.Restrict).IsRequired(true);

            modelBuilder.Entity<Doctor>()
            .Property(p => p.Salary)
           .HasColumnType("decimal(18,2)");

        }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<DoctorSpec> DoctorSpecs { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<OnlineUser> onlineUsers { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Specialization> Specializations { get; set; }
    }
}
