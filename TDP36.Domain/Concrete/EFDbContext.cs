using System.Data.Entity;
using TDP36.Domain.Entities;

namespace TDP36.Domain.Concrete
{
    public class EFDbContext : DbContext
    {
        public DbSet<Opponent> Opponents { get; set; }
        public DbSet<Character> Characters {  get; set; }
    }
}