using Microsoft.Extensions.DependencyInjection;

namespace NotesApplication.WPF.Registrars
{
    public class ApplicationServicesRegistrar : IApplicationServicesRegistrar
    {
        public void RegisterServices(ServiceCollection services)
        {
            services.AddSingleton<MainWindow>();
        }
    }
}
