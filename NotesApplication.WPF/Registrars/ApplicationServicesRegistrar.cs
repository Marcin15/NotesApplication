using Microsoft.Extensions.DependencyInjection;
using NotesApplication.UseCases.ViewModels;

namespace NotesApplication.WPF.Registrars
{
    public class ApplicationServicesRegistrar : IApplicationServicesRegistrar
    {
        public void RegisterServices(ServiceCollection services)
        {
            services.AddSingleton<MainWindow>();
            services.AddSingleton<INewNoteViewModel, NewNoteViewModel>();
        }
    }
}
