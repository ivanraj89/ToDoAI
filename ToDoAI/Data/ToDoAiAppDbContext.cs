using Microsoft.EntityFrameworkCore;
using ToDoAI.Models;

namespace ToDoAI.Data
{
    public class ToDoAiAppDbContext : DbContext
    {
        public ToDoAiAppDbContext(DbContextOptions<ToDoAiAppDbContext> options) : base(options) 
        {
            
        }
        public DbSet<InputFields> InputFields { get; set; }
    }
}
