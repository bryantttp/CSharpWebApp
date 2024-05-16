using Microsoft.EntityFrameworkCore;
using MyFirstWebApplication.Models;

namespace MyFirstWebApplication.Context
{
    public class PostgreSQLDb : DbContext
    {
        public DbSet<Book> Books { get; set; }

        public PostgreSQLDb(DbContextOptions<PostgreSQLDb> options) : base(options) { }
    }
}
