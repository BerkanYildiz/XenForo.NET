namespace XenForo.NET.Models
{
    using Newtonsoft.Json;

    public class User
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="User"/> class.
        /// </summary>
        public User()
        {
            // User.
        }

        [JsonProperty("user_like_count")]
        public long UserLikeCount
        {
            get;
            set;
        }

        [JsonProperty("user_message_count")]
        public long UserMessageCount
        {
            get;
            set;
        }

        [JsonProperty("user_register_date")]
        public long UserRegisterDate
        {
            get;
            set;
        }

        [JsonProperty("user_id")]
        public long UserId
        {
            get;
            set;
        }

        [JsonProperty("username")]
        public string Username
        {
            get;
            set;
        }

        [JsonProperty("user_dob_day")]
        public long UserDobDay
        {
            get;
            set;
        }

        [JsonProperty("user_dob_month")]
        public long UserDobMonth
        {
            get;
            set;
        }

        [JsonProperty("user_dob_year")]
        public long UserDobYear
        {
            get;
            set;
        }

        [JsonProperty("user_email")]
        public string UserEmail
        {
            get;
            set;
        }

        [JsonProperty("user_external_authentications")]
        public object[] UserExternalAuthentications
        {
            get;
            set;
        }

        [JsonProperty("user_groups")]
        public UserGroup[] UserGroups
        {
            get;
            set;
        }

        [JsonProperty("user_has_password")]
        public bool UserHasPassword
        {
            get;
            set;
        }

        [JsonProperty("user_is_followed")]
        public bool UserIsFollowed
        {
            get;
            set;
        }

        [JsonProperty("user_is_ignored")]
        public bool UserIsIgnored
        {
            get;
            set;
        }

        [JsonProperty("user_is_valid")]
        public bool UserIsValid
        {
            get;
            set;
        }

        [JsonProperty("user_is_verified")]
        public bool UserIsVerified
        {
            get;
            set;
        }

        [JsonProperty("user_is_visitor")]
        public bool UserIsVisitor
        {
            get;
            set;
        }

        [JsonProperty("user_last_seen_date")]
        public long UserLastSeenDate
        {
            get;
            set;
        }

        [JsonProperty("self_permissions")]
        public SelfPermissions SelfPermissions
        {
            get;
            set;
        }

        [JsonProperty("user_timezone_offset")]
        public long UserTimezoneOffset
        {
            get;
            set;
        }

        [JsonProperty("user_title")]
        public string UserTitle
        {
            get;
            set;
        }

        [JsonProperty("user_unread_notification_count")]
        public long UserUnreadNotificationCount
        {
            get;
            set;
        }

        [JsonProperty("links")]
        public Links Links
        {
            get;
            set;
        }

        [JsonProperty("permissions")]
        public Permissions Permissions
        {
            get;
            set;
        }
    }
}
