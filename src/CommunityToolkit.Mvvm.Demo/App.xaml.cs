using LayUI.Wpf.CommunityToolkit.Mvvm;
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Windows;

namespace CommunityToolkit.Mvvm.Demo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : LayUIApplication
    {
        protected override Window CreateShell()
        {
            return new MainWindow();
        }  
        protected override void RegisterTypes(IServiceCollection services)
        {
            services.RegisterDialog();
            services.RegisterForNavigation();
            services.RegisterMef();
        } 
    }

}
