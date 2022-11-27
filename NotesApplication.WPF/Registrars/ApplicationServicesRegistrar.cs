using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NotesApplication.Infrastructure;
using NotesApplication.UseCases.Services;
using NotesApplication.UseCases.Stores;
using NotesApplication.UseCases.ViewModels;

namespace NotesApplication.WPF.Registrars
{
    public class ApplicationServicesRegistrar : IApplicationServicesRegistrar
    {
        public void RegisterServices(ApplicationBuilder builder)
        {
            builder.Services.AddTransient<MainWindow>();
            builder.Services.AddSingleton(builder.Configuration);
            builder.Services.AddSingleton<INewNoteViewModel, NewNoteViewModel>();
            builder.Services.AddSingleton<IMainViewModel, MainViewModel>();
            builder.Services.AddSingleton<IUserService, UserService>();
            builder.Services.AddSingleton<INoteService, NoteService>();
            builder.Services.AddSingleton<IAccountStore, AccountStore>();
        }
    }
}
