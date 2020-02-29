using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Facpag.Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<MyContext>
    {
        public MyContext CreateDbContext(string[] args)
        {
            //Use to create migrations
            var connectionString = "Server=localhost;Port=3306;Database=facturacion; Uid=root;Pwd=;"; //MySql
            // var connectionString = "Data Source=facturacion.db;Version=3;"; //SQLite
            var optionsBuilder = new DbContextOptionsBuilder<MyContext>();
            optionsBuilder.UseMySql(connectionString);
            // optionsBuilder.UseSqlite(connectionString);
            return new MyContext(optionsBuilder.Options);
        }
    }
}
