using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
    public class TodoContext : DbContext
    {
        protected readonly IConfiguration Config;
        public TodoContext(IConfiguration cofig)
        {
            Config = cofig;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseNpgsql(Config.GetConnectionString("PostgresConnection"));
        }

        public DbSet<TodoItem> TodoItems { get; set; } = null!;
    }
}
