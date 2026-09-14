using Microsoft.EntityFrameworkCore;

public class Exercise2Week3Context(DbContextOptions<Exercise2Week3Context> options) : DbContext(options)
{
    public DbSet<Exercise2Week3.Pages.Models.AccountHolder> AccountHolder { get; set; } = default!;
}
