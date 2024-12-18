using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LayUI.Wpf.CommunityToolkit.Mvvm
{
    public class ViewModelLocator
    { 
        public static bool GetAutoWireViewModel(DependencyObject obj)
        {
            return (bool)obj.GetValue(AutoWireViewModelProperty);
        } 
        public static void SetAutoWireViewModel(DependencyObject obj, bool value)
        {
            obj.SetValue(AutoWireViewModelProperty, value);
        }

        // Using a DependencyProperty as the backing store for AutoWireViewModel.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty AutoWireViewModelProperty =
            DependencyProperty.RegisterAttached("AutoWireViewModel", typeof(bool), typeof(ViewModelLocator), new PropertyMetadata(OnAutoWireViewModelChanged));

        private static void OnAutoWireViewModelChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {

            if (!DesignerProperties.GetIsInDesignMode(d) && (bool)e.NewValue)
            {
                Bind()
            }
        }
        private static void Bind(object view, object viewModel)
        {
            if (view is FrameworkElement frameworkElement)
            {
                frameworkElement.DataContext = viewModel;
            }
        }
    }
}
