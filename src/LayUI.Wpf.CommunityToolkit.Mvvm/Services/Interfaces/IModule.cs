using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayUI.Wpf.CommunityToolkit.Mvvm
{
    public interface IModule
    {
        void OnInitialized(IServiceProvider serviceProvider);
        void RegisterTypes(IServiceCollection  serviceDescriptors);
    }
}
