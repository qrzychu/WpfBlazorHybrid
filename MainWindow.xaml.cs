using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using MudBlazor.Services;

namespace Wpf.Blazor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddWpfBlazorWebView();

            serviceCollection.AddBlazorWebViewDeveloperTools();
            serviceCollection.AddMudServices();
            
            Resources.Add("services", serviceCollection.BuildServiceProvider());
        }
    }
}