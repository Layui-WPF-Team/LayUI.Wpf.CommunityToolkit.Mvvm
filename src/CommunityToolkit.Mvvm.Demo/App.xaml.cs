using LayUI.Wpf.CommunityToolkit.Mvvm.Core;
using LayUI.Wpf.CommunityToolkit.Mvvm.Dialog;
using LayUI.Wpf.CommunityToolkit.Mvvm.MEF;
using LayUI.Wpf.CommunityToolkit.Mvvm.Navigation;
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
            services.InitializeDialog();
            services.InitializeNavigation();
            services.InitializeMef();
        } 
    }

}
