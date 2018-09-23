namespace XenForo.NET
{
    using System;

    public sealed class XenForoConfig
    {
        /// <summary>
        /// Gets the URL.
        /// </summary>
        public string Url
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the client identifier.
        /// </summary>
        public string ClientId
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the client secret.
        /// </summary>
        public string ClientSecret
        {
            get;
            private set;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="XenForoConfig"/> class.
        /// </summary>
        public XenForoConfig(string Url = "", string ClientId = "", string ClientSecret = "")
        {
            this.SetUrl(Url);
            this.SetCredentials(ClientId, ClientSecret);
        }

        /// <summary>
        /// Sets the URL.
        /// </summary>
        /// <param name="Url">The URL.</param>
        public void SetUrl(string Url)
        {
            if (Uri.TryCreate(Url, UriKind.Absolute, out var Result) && (Result.Scheme == Uri.UriSchemeHttp || Result.Scheme == Uri.UriSchemeHttps) == false)
            {
                throw new Exception("The URL passed as argument to XenForoConfig is invalid!");
            }

            this.Url = Url;
        }

        /// <summary>
        /// Sets the credentials.
        /// </summary>
        /// <param name="ClientId">The client identifier.</param>
        /// <param name="ClientSecret">The client secret.</param>
        public void SetCredentials(string ClientId, string ClientSecret)
        {
            this.ClientId       = ClientId;
            this.ClientSecret   = ClientSecret;
        }

        /// <summary>
        /// Initializes a new instance of <see cref="XenForoConfig"/> froms the passed URL.
        /// </summary>
        /// <param name="Url">The URL.</param>
        public static XenForoConfig FromUrl(string Url)
        {
            return new XenForoConfig(Url);
        }

        /// <summary>
        /// Initializes a new instance of <see cref="XenForoConfig"/> without any datas.
        /// </summary>
        public static XenForoConfig Empty
        {
            get
            {
                return new XenForoConfig();
            }
        }
    }
}
