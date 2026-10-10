using Microsoft.EntityFrameworkCore;

namespace SubSplitter.Api.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
}