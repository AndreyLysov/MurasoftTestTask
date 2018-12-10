using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MurTestTask.helpers
{
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
