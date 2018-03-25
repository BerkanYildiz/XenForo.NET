namespace XenForo.NET.Models.Api
{
    using System;

    using XenForo.NET.Models.Enums;

    public class Token
    {
        /// <summary>
        /// Gets the access token.
        /// </summary>
        public string AccessKey
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the refresh token.
        /// </summary>
        public string RefreshKey
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the type of the token.
        /// </summary>
        public TokenType Type
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the token creation date.
        /// </summary>
        public DateTime CreationDate
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the duration of the token.
        /// </summary>
        public TimeSpan Duration
        {
            get;
            private set;
        }

        /// <summary>
        /// Gets the token expiration date.
        /// </summary>
        public DateTime ExpirationDate
        {
            get
            {
                return this.CreationDate.Add(this.Duration);
            }
        }

        /// <summary>
        /// Gets a value indicating whether this instance is expired.
        /// </summary>
        public bool IsExpired
        {
            get
            {
                return DateTime.UtcNow >= this.ExpirationDate;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Token"/> class.
        /// </summary>
        /// <param name="AccessKey">The access key.</param>
        /// <param name="RefreshKey">The refresh key.</param>
        /// <param name="Type">The type.</param>
        public Token(string AccessKey, string RefreshKey, TokenType Type)
        {
            this.SetCreationDate(DateTime.UtcNow);

            this.AccessKey  = AccessKey;
            this.RefreshKey = RefreshKey;
            this.Type       = Type;
        }

        /// <summary>
        /// Sets the token.
        /// </summary>
        public void SetToken(string AccessKey, string RefreshKey = null, bool SetCreationDate = true)
        {
            if (SetCreationDate)
            {
                this.SetCreationDate(DateTime.UtcNow);
            }

            this.AccessKey = AccessKey;

            if (string.IsNullOrEmpty(RefreshKey) == false)
            {
                this.RefreshKey = RefreshKey;
            }
        }

        /// <summary>
        /// Sets the creation date.
        /// </summary>
        /// <param name="Date">The date.</param>
        public void SetCreationDate(DateTime Date)
        {
            this.CreationDate = Date;
        }

        /// <summary>
        /// Sets the duration.
        /// </summary>
        /// <param name="Duration">The duration.</param>
        public void SetDuration(TimeSpan Duration)
        {
            this.Duration = Duration;
        }

        /// <summary>
        /// Sets the type of the token.
        /// </summary>
        /// <param name="Type">The type.</param>
        public void SetTokenType(TokenType Type)
        {
            this.Type = Type;
        }
    }
}
