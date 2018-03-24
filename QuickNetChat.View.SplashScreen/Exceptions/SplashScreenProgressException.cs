using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickNetChat.View.SplashScreen.Exceptions
{
    public class SplashScreenProgressException : Exception
    {
        public SplashScreenProgressException(string message) : base(CustomExceptionMessage(message))
        {
        }

        private static string CustomExceptionMessage(string message)
        {
            return $"SplashScreen progress - {message}";
        }
    }
}
