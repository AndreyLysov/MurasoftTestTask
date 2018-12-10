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
        private StartHelper startHelper;
        private LoginHelper loginHelper;

        public BaseHelper Base()
        {
            return baseHelper == null 
                ? baseHelper = new BaseHelper() 
                : baseHelper;
        }

        public StartHelper Start()
        {
            return startHelper == null
                ? startHelper = new StartHelper()
                : startHelper;
        }

        public LoginHelper Login()
        {
            return loginHelper == null
                ? loginHelper = new LoginHelper()
                : loginHelper;
        }
    }
}
