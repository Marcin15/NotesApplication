using Microsoft.Extensions.DependencyInjection;

namespace NotesApplication.WPF.Registrars
{
    public interface IApplicationServicesRegistrar
    {
        void RegisterServices(ServiceCollection services);
    }
}
