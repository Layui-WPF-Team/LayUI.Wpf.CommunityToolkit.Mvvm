using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayUI.Wpf.CommunityToolkit.Mvvm
{
    public static class MefExtension
    {
        public static void InitializeMef(this IServiceCollection services)
        {
            var service = new MEFService();
            service.Run();
            services.AddSingleton<IMEFService>(service);
        }
    }
}
