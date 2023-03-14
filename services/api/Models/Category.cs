using Microsoft.EntityFrameworkCore;

public class Category
{
    public int CategoryId { get; set; }
    public string Title { get; set; }
}

public class CategoryContext : Infrastructure.Database.Context
{
    public DbSet<Category> Categories { get; set; }
}
