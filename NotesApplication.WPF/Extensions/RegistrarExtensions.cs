using Microsoft.Extensions.DependencyInjection;
using NotesApplication.WPF.Registrars;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NotesApplication.WPF.Extensions
{
    public static class RegistrarExtensions
    {
        public static void RegisterServices(this ServiceCollection services, Type scanningType)
        {
            var registrars = GetRegistrars<IApplicationServicesRegistrar>(scanningType);

            foreach (var registrar in registrars)
            {
                registrar.RegisterServices(services);
            }
        }

        private static IEnumerable<T> GetRegistrars<T>(Type scanningType)
        {
            return scanningType.Assembly.GetTypes()
                .Where(t => t.IsAssignableTo(typeof(T)) && !t.IsInterface)
                .Select(Activator.CreateInstance)   
                .Cast<T>();
        }
    }
}
