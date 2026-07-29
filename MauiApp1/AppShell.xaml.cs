using MauiApp1.Views;

namespace MauiApp1
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(RecDemoView),typeof(RecDemoView));
            Routing.RegisterRoute(nameof(TestPage),typeof(TestPage));
        }
    }
}
