namespace XenForo.NET.Models
{
    using Newtonsoft.Json;

    public class UserGroup
    {
        [JsonProperty("user_group_id")]
        public long UserGroupId
        {
            get;
            set;
        }

        [JsonProperty("user_group_title")]
        public string UserGroupTitle
        {
            get;
            set;
        }

        [JsonProperty("is_primary_group")]
        public bool IsPrimaryGroup
        {
            get;
            set;
        }
    }
}