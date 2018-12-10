namespace MurTestTask.helpers
{
    //Application manager which stores all helpers for working with the application.
    public class App
    {
        private BaseHelper baseHelper;
        private MainHelper mainHelper;
        private LoginHelper loginHelper;

        public BaseHelper Base()
        {
            return baseHelper == null 
                ? baseHelper = new BaseHelper() 
                : baseHelper;
        }

        public MainHelper Main()
        {
            return mainHelper == null
                ? mainHelper = new MainHelper()
                : mainHelper;
        }

        public LoginHelper Login()
        {
            return loginHelper == null
                ? loginHelper = new LoginHelper()
                : loginHelper;
        }
    }
}
