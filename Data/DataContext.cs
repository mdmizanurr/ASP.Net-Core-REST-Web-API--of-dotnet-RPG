using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace dotnet_RPG.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }        

        public DbSet<Character> Characters { get; set; }
        public DbSet<User> Users { get; set; }
        
    }
}