using Atata;

namespace AtataDemoTestProject
{
    using _ = OurTeamPage;

    public class OurTeamPage : Page<_>
    {

        [FindByXPath("(//img[@class='testimonial-picture'])[1]")]
        [WaitFor(Until.Visible, TriggerEvents.BeforeAnyAction)]
        public Image<_>  BrainImg { get; private set; }

        [FindByXPath("(//img[@class='testimonial-picture'])[3]")]
        [WaitFor(Until.Visible, TriggerEvents.BeforeAnyAction)]
        public Image<_> BenImg { get; private set; }

        [FindByXPath("(//div[@class='team-card-fake-link'])[3]")]
        [WaitFor(Until.Visible, TriggerEvents.BeforeAnyAction)]
        public Clickable<_> BenViewMore { get; private set; }

        [FindByXPath("//p[@class='mg-top-24px']")]
        [WaitFor(Until.Visible, TriggerEvents.BeforeAnyAction)]
        public Text<_> BenDetails { get; private set; }
    }
}
