using Atata;

namespace AtataDemoTestProject
{
    using _ = RequestDemoPage;

    public class RequestDemoPage : Page<_>
    {

        [FindByName("Full-Name")]
        [GetsContentFromAttribute("placeholder")]
        [WaitFor(Until.Visible, TriggerEvents.BeforeAnyAction)]
        public TextInput<_>  NameInput { get; private set; }

        [FindByName("Email")]
        [GetsContentFromAttribute("placeholder")]
        [WaitFor(Until.Visible, TriggerEvents.BeforeAnyAction)]
        public TextInput<_> EmailInput { get; private set; }


    }
}
