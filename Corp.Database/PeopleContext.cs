using Microsoft.EntityFrameworkCore;
using Corp.Model;

namespace Corp.Database;

public class PeopleContext : DbContext
{
    public DbSet<Person> Persons { get; set; }

    public DbSet<Address> Addresses { get; set; }

    public DbSet<Contract> Contracts { get; set; }

    private string _dbPath = @"C:\Temp\people.db";

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={_dbPath}");

}
