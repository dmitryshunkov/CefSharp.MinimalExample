using CefSharp.WinForms;
using System.Windows;

namespace CefSharp.MinimalExample.Wpf
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            (windowFormsHost.Child as ChromiumWebBrowser).Load("www.google.com");
        }
    }
}
