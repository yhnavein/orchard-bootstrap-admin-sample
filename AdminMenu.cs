using Orchard.UI.Navigation;
using Orchard.Localization;
using Orchard.Environment.Extensions;

namespace BootstrapAdminSample
{
    [OrchardFeature("BootstrapAdminSample")]
    public class AdminMenu : INavigationProvider
    {
        public Localizer T { get; set; }

        public AdminMenu()
        {
            T = NullLocalizer.Instance;
        }
        private const string AreaName = "BootstrapAdminSample";

        public string MenuName { get { return "admin"; } }

        public void GetNavigation(NavigationBuilder builder)
        {
            builder.AddImageSet("bootstrap")
                .Add(T("Bootstrap"), "5",
                    menu => menu
                        .Add(T("Bootstrap Sample"), "0",
                            item => item.Action("Index", "Sample", new { area = AreaName })));

        }
    }
}