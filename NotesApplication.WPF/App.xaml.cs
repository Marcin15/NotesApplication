using Microsoft.Extensions.DependencyInjection;
using NotesApplication.WPF.Extensions;
using System.Windows;

namespace NotesApplication.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var builder = new ApplicationBuilder();
            
            builder.RegisterServices(typeof(App));

            var application = builder.Build();

            var mainWindow = application.GetService<MainWindow>();
            mainWindow.Show();
        }
    }
}
