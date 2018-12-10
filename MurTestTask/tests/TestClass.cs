using MurTestTask.models;
using NUnit.Framework;

namespace MurTestTask.tests
{
    class TestClass : BaseTest
    {
        private UserData user;

        [SetUp]
        public void initializePreconditions()
        {
            user = new UserData()
                .withEmail("invalid")
                .withPassword("");
        }

        [Test]
        public void checkInvalidEmailWarningDisplaying()
        {
            app.Start().OpenLoginForm();
            app.Login().FillInform(user);
            Assert.AreEqual(app.Login().GetEmailWarningText(), "Invalid email format.");
        }
    }
}
