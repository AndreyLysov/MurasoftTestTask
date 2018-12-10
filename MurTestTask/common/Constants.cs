using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MurTestTask.common
{
    public static class Constants
    {
        private static int implicitWait = 5;
        private static int explicitWait = 10;

        public static int ImplicitWait { get => implicitWait; }
        public static int ExplicitWait { get => explicitWait; }
    }
}
