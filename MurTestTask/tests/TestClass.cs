using MurTestTask.models;
using NUnit.Framework;

namespace MurTestTask.tests
{
    class TestClass : BaseTest
    {
        private UserData user;

        [SetUp]
        public void InitializePreconditions()
        {
            user = new UserData()
            {
                Email = "invalid"
            };
        }

        [Test]
        public void CheckInvalidEmailWarningDisplaying()
        {
            app.Start().OpenLoginForm();
            app.Login().FillInform(user);
            Assert.AreEqual(app.Login().GetEmailWarningText(), "Invalid email format.");
        }
    }
}
