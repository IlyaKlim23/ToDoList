using Microsoft.EntityFrameworkCore;
using ToDoList.Domain.Entity;

namespace ToDoList.DAL;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        Database.EnsureCreated();
    }

    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //     optionsBuilder.LogTo(Console.WriteLine);
    // }

    public DbSet<TaskEntity> Tasks { get; set; }
}