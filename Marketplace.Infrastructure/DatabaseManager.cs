using Microsoft.EntityFrameworkCore;



public class DatabaseManager :DbContext
{

    public DbSet<User> Users { get; set; }
    public DbSet<Item> Items { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        
        optionsBuilder.UseNpgsql("Host=localhost;Database=market;Username=postgres;Password=root");
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<User>()
            .HasMany(u => u.Items)
            .WithMany(i => i.Users)
            .UsingEntity(j => j.ToTable("UserItems"));
    }
    
    public void InitializeDatabase()
    {
        Database.Migrate();
    }
}
