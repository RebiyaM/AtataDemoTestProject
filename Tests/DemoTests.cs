using NUnit.Framework;
using Atata;

namespace AtataDemoTestProject
{
    public class DemoTests : UITestFixture
    {

        [Test, Order(1), Category("smoke")]
        public void RequestDemoTestVerifyDefaultTextOfNameAndEmail()
        {
            Go.To<HomePage>()
                .RequestDemo.ClickAndGo()
                .NameInput.Should.WithinSeconds(5).Exist()
                .NameInput.Content.Should.Contain("What's your name?")
                .EmailInput.Should.WithinSeconds(5).Exist()
                .EmailInput.Content.Should.Contain("What's your email?");
        }


        [Test, Order(2), Category("smoke")]
        public void OurTeamTestVerifyDefaultTextOfNameAndEmail()
        {
            Go.To<HomePage>()
                .AboutUs.Click()
                .OurTeam.ClickAndGo()
                .BrainImg.Should.WithinSeconds(5).BePresent()
                .BenImg.Should.WithinSeconds(5).BePresent();
        }

        [Test, Order(3), Category("smoke")]
        public void OurTeamTestViewBenDetails()
        {
            Go.To<HomePage>()
                .AboutUs.Click()
                .OurTeam.ClickAndGo()
                .BrainImg.Should.WithinSeconds(5).BePresent()
                .BenViewMore.Should.WithinSeconds(5).BePresent()
                .BenViewMore.Click()
                .BenDetails.Should.WithinSeconds(5).BePresent()
                .BenDetails.Should.Contain("Ben joined AHTG in 2017 and currently serves as the Vice President.");
        }

        [Test, Order(3), Category("smoke")]
        public void OurProductTestViewBenDetails()
        {
            Go.To<HomePage>()
                .OurProducts.ClickAndGo()
                .PageUrl.Should.Contain("our-products")
                .TrioVMS.Should.WithinSeconds(10).Exist()
                .InsightATS.Should.WithinSeconds(10).Exist()
                .RequestDemoLink.Should.WithinSeconds(10).Exist();
        }

    }
}
