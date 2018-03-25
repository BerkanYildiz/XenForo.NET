namespace XenForo.NET.Example
{
    using System;

    using XenForo.NET;

    public static class Program
    {
        public const string Url             = "https://www.weplaylegit.com/api/";

        public const string ClientId        = "";
        public const string ClientSecret    = "";

        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        public static void Main()
        {
            XenForoConfig Config = new XenForoConfig(Url, ClientId, ClientSecret);
            XenforoApi XenForo   = new XenforoApi(Config);

            XenForo.Authenticate("", "");

            if (XenForo.IsAuthenticated)
            {
                Logging.Info(typeof(Program), "We are authenticated.");
            }
            else
            {
                Logging.Warning(typeof(Program), "XenForo.IsAuthenticated != true at Main().");
            }

            Console.ReadKey();
        }
    }
}
