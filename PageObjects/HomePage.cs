using Atata;

namespace AtataDemoTestProject
{
    using _ = HomePage;
    [VerifyTitle]
    public class HomePage : Page<_>
    {
        [FindByContent("request a demo")]
        [WaitFor(Until.Visible, TriggerEvents.BeforeAnyAction)]
        public Link<RequestDemoPage, _> RequestDemo { get; private set; }

        [FindByContent("our products")]
        [WaitFor(Until.Visible, TriggerEvents.BeforeAnyAction)]
        public Link<OurProductsPage, _> OurProducts { get; private set; }

        [FindByXPath("//div[@class='dropdown-text']")]
        [WaitFor(Until.Visible, TriggerEvents.BeforeAnyAction)]
        public Clickable<_> AboutUs { get; private set; }

        [FindByXPath("(//a[@class='mega-menu-nav-link'])[2]")]
        [WaitFor(Until.Visible, TriggerEvents.BeforeAnyAction)]
        public Clickable<OurTeamPage, _> OurTeam { get; private set; }
    }
}
