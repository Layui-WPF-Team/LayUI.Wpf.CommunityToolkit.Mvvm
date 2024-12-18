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
        public static void RegisterForNavigation<TView, TViewModel>(this IServiceCollection services)
        {
            RegisterForNavigation<TView, TViewModel>(services, typeof(TView).Name, typeof(TViewModel).Name);
        }
        public static void RegisterForNavigation<TView, TViewModel>(this IServiceCollection services, string viewName, string viewModelName)
        { 
            services.AddKeyedScoped(typeof(TView), viewName);
            services.AddKeyedScoped(typeof(TViewModel), viewModelName);
        } 
    }
}
