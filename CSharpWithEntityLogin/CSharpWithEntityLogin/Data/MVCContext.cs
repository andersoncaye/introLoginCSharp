using CSharpWithEntityLogin.Models;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;

namespace CSharpWithEntityLogin.Data
{
    public class MVCContext : DbContext
    {
        
        public MVCContext() 
            : base("MVCContext_Desenv")
        {

        }

        public DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}