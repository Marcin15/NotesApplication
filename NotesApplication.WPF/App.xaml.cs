using Microsoft.Extensions.DependencyInjection;
using NotesApplication.WPF.Extensions;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace NotesApplication.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly ServiceProvider _serviceProvider;
        public App()
        {
            var services = new ServiceCollection();
            services.RegisterServices(typeof(App));
            _serviceProvider = services.BuildServiceProvider();
        }

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var application = _serviceProvider.GetService<MainWindow>();
            application.Show();
        }
    }
}
