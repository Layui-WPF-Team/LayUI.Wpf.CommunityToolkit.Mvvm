using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayUI.Wpf.CommunityToolkit.Mvvm
{
    public static class NavigationExtension
    {
        public static void RegisterForNavigation<TView>(this IServiceCollection services)
        {
            RegisterForNavigation<TView>(services, null);
        }
        public static void RegisterForNavigation<TView>(this IServiceCollection services, string name = null)
        {
            Type typeFromHandle = typeof(TView);
            string name2 = (string.IsNullOrWhiteSpace(name) ? typeFromHandle.Name : name);
            RegisterForNavigation(services, typeFromHandle, name2);
        }
        public static void RegisterForNavigation<TView, TViewModel>(this IServiceCollection services)
        {
            RegisterForNavigation<TView, TViewModel>(services, null);
        }
        public static void RegisterForNavigation<TView, TViewModel>(this IServiceCollection services, string name = null)
        {
            RegisterForNavigationWithViewModel<TViewModel>(services, typeof(TView), name);
        }
        private static void RegisterForNavigation(this IServiceCollection services, Type type, string name = null)
        {
            services.AddKeyedScoped(typeof(object), name, type);
        }
        private static void RegisterForNavigationWithViewModel<TViewModel>(this IServiceCollection services, Type viewType, string name = null)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                name = viewType.Name;
            } 
            RegisterForNavigation(services, viewType, name);
        }
    }
}
