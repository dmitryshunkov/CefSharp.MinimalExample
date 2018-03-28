using CefSharp.WinForms;
using System.Windows;

namespace CefSharp.MinimalExample.Wpf
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var chromiumBrowser = (windowFormsHost.Child as ChromiumWebBrowser);
            chromiumBrowser.FocusHandler = null;
            chromiumBrowser.Load("www.google.com");
        }
    }
}
