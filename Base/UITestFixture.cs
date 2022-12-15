using Atata;
using NUnit.Framework;

namespace AtataDemoTestProject
{
    [TestFixture]
    [Parallelizable(ParallelScope.All)]
    public abstract class UITestFixture
    {
        public static AtataConfig Config =>
            AtataConfig.Current;

        [SetUp]
        public void SetUp()
        {
            AtataContext.Configure().Build();
        }

        [TearDown]
        public void TearDown()
        {
            AtataContext.Current?.CleanUp();
        }


    }
}
