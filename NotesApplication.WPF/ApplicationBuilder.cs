using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;

namespace NotesApplication.WPF
{
    public class ApplicationBuilder
    {
        public IConfiguration Configuration { get; private set; }
        public IServiceCollection Services { get; private set; }
        public ApplicationBuilder()
        {
            AddConfiguraion();
            AddServiceCollection();
        }

        public ServiceProvider Build() => Services.BuildServiceProvider();

        public void AddConfiguraion()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(GetProjectDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            Configuration = builder.Build();
        }

        private void AddServiceCollection()
        {
            Services = new ServiceCollection();
        }

        private string GetProjectDirectory()
        {
            var workingDirectory = Environment.CurrentDirectory;

            return Directory.GetParent(workingDirectory).Parent.Parent.FullName;
        }
    }
}
