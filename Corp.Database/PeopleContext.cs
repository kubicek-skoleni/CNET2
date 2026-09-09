using Microsoft.EntityFrameworkCore;
using Corp.Model;

namespace Corp.Database;

public class PeopleContext : DbContext
{
    public DbSet<Person> Persons { get; set; }

    public DbSet<Address> Addresses { get; set; }

    public DbSet<Contract> Contracts { get; set; }


}
