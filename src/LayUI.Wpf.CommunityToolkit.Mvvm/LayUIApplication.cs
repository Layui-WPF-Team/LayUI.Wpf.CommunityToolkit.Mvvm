using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows;
namespace LayUI.Wpf.CommunityToolkit.Mvvm
{
    public abstract class LayUIApplication : Application
    {
        public IServiceProvider Container;
        protected override void OnStartup(StartupEventArgs e)
        {
            Initialize();
            base.OnStartup(e);
        }
        protected abstract Window CreateShell();
        public virtual IServiceCollection CreateContainerExtension() => new ServiceCollection();
        protected abstract void RegisterTypes(IServiceCollection services);
        public virtual void Initialize()
        {
            var service = CreateContainerExtension();
            RegisterTypes(service);
            ContainerLocator.SetContainerExtension(service);
            Container = ContainerLocator.Container;
            var shell = CreateShell();
            if (shell != null)
            {
                InitializeShell(shell);
            }
            OnInitialized();
        }
        protected virtual void InitializeShell(Window shell)
        {
            MainWindow = shell;
        }

        public virtual void OnInitialized()
        {
            (MainWindow as Window)?.Show();
        }
    }
}
