using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NotesApplication.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesApplication.WPF.Registrars
{
    public class DbContextRegistrar : IApplicationServicesRegistrar
    {
        public void RegisterServices(ApplicationBuilder builder)
        {
            builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("default")));
        }
    }
}
