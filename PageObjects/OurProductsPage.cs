using Atata;

namespace AtataDemoTestProject
{
    using _ = OurProductsPage;

    public class OurProductsPage : Page<_>
    {

        [FindByContent("Trio VMS")]
        [WaitFor(Until.Visible, TriggerEvents.BeforeAnyAction)]
        public H2<_>  TrioVMS { get; private set; }

        [FindByContent("Insight ATS+")]
        [WaitFor(Until.Visible, TriggerEvents.BeforeAnyAction)]
        public H2<_> InsightATS { get; private set; }

        [FindByContent("request a demo")]
        [WaitFor(Until.Visible, TriggerEvents.BeforeAnyAction)]
        public Link<_> RequestDemoLink { get; private set; }

    }
}
