using Microsoft.EntityFrameworkCore;

namespace Lab5.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
           
        }

        public DbSet<Census> TodoItems { get; set; }



    }
}
