using Atata;
using Atata.WebDriverSetup;
using NUnit.Framework;
using System;

namespace AtataDemoTestProject
{
    [SetUpFixture]
    public class SetUpFixture
    {
        private enum BrowserType
        {
            Chrome,
            Firefox
        }

        [OneTimeSetUp]
        public void GlobalSetUp()
        {
            string driverAlias = TestContext.Parameters.Get("DriverAlias", DriverAliases.Chrome);

            string testEnvironmentAlias = TestContext.Parameters.Get("TestEnvironment", "chrome");
            AtataContext.GlobalConfiguration
                       .ApplyJsonConfig<AtataConfig>()
                       .ApplyJsonConfig<AtataConfig>(environmentAlias: testEnvironmentAlias)
                .UseDriver(driverAlias);

            DriverSetup.GetDefaultConfiguration(BrowserNames.Firefox)
                .WithX64Architecture();

            AtataContext.GlobalConfiguration.AutoSetUpDriverToUse();
            AtataContext.GlobalConfiguration
            .EventSubscriptions.Add<DriverInitEvent>(e => e.Driver.Maximize());

            AtataContext.GlobalConfiguration
          .EventSubscriptions.UseElementFindTimeout(TimeSpan.FromSeconds(30))
          .UseWaitingTimeout(TimeSpan.FromSeconds(30))
          //.UseWaitingRetryInterval(TimeSpan.FromSeconds(30))
          .UseVerificationTimeout(TimeSpan.FromSeconds(30));
            // .UseVerificationRetryInterval(TimeSpan.FromSeconds(30));
        }
    }
}
