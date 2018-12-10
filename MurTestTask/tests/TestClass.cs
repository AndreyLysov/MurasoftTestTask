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
            app.Main().OpenLoginForm();
            app.Login().FillInform(user);

            //You can replace valid text with invalid to check error message
            string expectedResult = "Invalid email format.";
            string actualResult = app.Login().GetEmailWarningText();

            //Third parameter (message) was added for more detailed information about the error
            Assert.AreEqual(expectedResult, actualResult,
                string.Format(
                    "Expecter result: '{0}'\n" + 
                    "Actual result: '{1}'",
                    expectedResult,
                    actualResult));
        }
    }
}
