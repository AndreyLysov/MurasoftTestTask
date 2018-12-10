using MurTestTask.helpers;
using NUnit.Framework;

namespace MurTestTask.tests
{
    class BaseTest
    {
        protected App app = new App();

        [SetUp]
        public void Init()
        {
            app.Base().StartApp();
        }

        [TearDown]
        public void CleanUp()
        {
            app.Base().StopApp();
        }
    }
}
