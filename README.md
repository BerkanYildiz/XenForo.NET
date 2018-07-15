# XenForo.NET
C# client library for the [XenForo (2) API add-on](https://github.com/xfrocks/bdApi/tree/xenforo2).

# Example

```csharp
namespace XenForo.NET.Example
{
    using System;

    using XenForo.NET;

    public static class Program
    {
        public const string Url             = "https://www.weplaylegit.com/api/";

        public const string ClientId        = "<client id>";
        public const string ClientSecret    = "<client secret>";

        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        public static void Main()
        {
            XenForoConfig Config = new XenForoConfig(Url, ClientId, ClientSecret);
            XenforoApi XenForo   = new XenforoApi(Config);

            XenForo.Authenticate("<username>", "<password>");

            if (XenForo.IsAuthenticated)
            {
                // We are authenticated
				
		User User = XenForo.GetUser(Identifier: 1);

                if (User != null)
                {
                    Console.WriteLine("[*] Username : " + User.Username + ".");
                }
            }
            else
            {
                // We are not authenticated
            }

            Console.ReadKey();
        }
    }
}

```

# Licence
This work is licensed under the MIT License.
