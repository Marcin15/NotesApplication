using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace NotesApplication.Infrastructure
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<DataContext>
    {
        public DataContext CreateDbContext(string[] args)
        {
            var options = new DbContextOptionsBuilder().UseSqlServer("Server=(localdb)\\Marcin_dev;Database=NotesAppDb;User Id=Marcin_dev;Password=SAPa$$0000;").Options;

            return new DataContext(options);
        }
    }
}
