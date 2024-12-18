using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LayUI.Wpf.CommunityToolkit.Mvvm.Core
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    public class LayUIContainerLocator
    {
        private static IServiceProvider _current;

        public static bool IsInitialized => _current != null;

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static IServiceProvider Current => _current ?? throw new InvalidOperationException("You must initialize the Current Container.");

        public static IServiceProvider Container => Current;

        public static void SetContainerExtension(IServiceCollection serviceDescriptors)
        {
            _current = serviceDescriptors.BuildServiceProvider();
        } 
        public static bool TrySetContainerExtension(IServiceCollection serviceDescriptors)
        {
            if (_current != null)
            {
                return false;
            }
            _current = serviceDescriptors.BuildServiceProvider();
            return true;
        }

        [EditorBrowsable(EditorBrowsableState.Never)]
        public static void ResetContainer()
        {
            _current = null;
        }
    }
}
