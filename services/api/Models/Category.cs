using Microsoft.EntityFrameworkCore;

public class Category
{
    public int CategoryId { get; set; }
    public string Title { get; set; }
}

public class CategoryContext : DbContext
{
    public DbSet<Category> Categories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=lms-database-1; Database=lms; Username=lms; Password=lms;");
    }
}
