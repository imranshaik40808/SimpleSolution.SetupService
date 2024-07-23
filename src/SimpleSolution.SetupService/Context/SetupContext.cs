using Microsoft.EntityFrameworkCore;
using SimpleSolution.SetupService.Entities;
using SimpleSolution.SharedApi.ContextHelper;

public class SetupContext : BaseDbContext
{
    public SetupContext(DbContextOptionsBuilder<SetupContext> contextOptions) : base(contextOptions.Options)
    {
    }

    public DbSet<Country> Country { get; set; }
    public DbSet<State> State { get; set; }
    public DbSet<Pin> Pin { get; set; }
    public DbSet<Vendor> Vendor { get; set; }
    public DbSet<VendorAddress> VendorAddress { get; set; }
    public DbSet<VendorBusiness> VendorBusiness { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Country>()
         .HasKey(m => m.Id);

        modelBuilder.Entity<State>()
        .HasKey(m => m.Id);

        modelBuilder.Entity<Pin>()
         .HasKey(m => m.Id);

        modelBuilder.Entity<Vendor>()
          .HasKey(m => m.Id);

        modelBuilder.Entity<VendorAddress>()
        .HasKey(m => m.Id);

        modelBuilder.Entity<VendorBusiness>()
          .HasKey(m => m.Id);

        base.OnModelCreating(modelBuilder);
    }

}