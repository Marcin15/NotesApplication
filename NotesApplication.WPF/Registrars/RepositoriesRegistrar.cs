using Microsoft.Extensions.DependencyInjection;
using NotesApplication.Infrastructure.Repositories;
using NotesApplication.UseCases.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesApplication.WPF.Registrars
{
    public class RepositoriesRegistrar : IApplicationServicesRegistrar
    {
        public void RegisterServices(ApplicationBuilder builder)
        {
            builder.Services.AddTransient<IUserRepository, UserRepository>();
            builder.Services.AddTransient<INoteRepository, NoteRepository>();
        }
    }
}
