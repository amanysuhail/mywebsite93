using Microsoft.EntityFrameworkCore;
using myweb.API.Models;

namespace myweb.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<value> values { get; set; }
    }

}