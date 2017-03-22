using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace UwpTestApp
{
    public sealed partial class MacAddressControl : UserControl
    {
        public string SparePartMacAddress
        {
            get
            {
                return (string)GetValue(SparePartMacAddressProperty);
            }
            set
            {
                SetValue(SparePartMacAddressProperty, value);
            }
        }

        public static readonly DependencyProperty SparePartMacAddressProperty =
            DependencyProperty.Register(nameof(SparePartMacAddress), typeof(string), typeof(MacAddressControl), null);

        public MacAddressControl()
        {
            this.InitializeComponent();
            (this.Content as FrameworkElement).DataContext = this;
        }
       

        
    }
}
