namespace XenForo.NET.Models
{
    using Newtonsoft.Json;

    public class Permissions
    {
        [JsonProperty("edit")]
        public bool Edit
        {
            get;
            set;
        }

        [JsonProperty("ignore")]
        public bool Ignore
        {
            get;
            set;
        }

        [JsonProperty("follow")]
        public bool Follow
        {
            get;
            set;
        }

        [JsonProperty("profile_post")]
        public bool ProfilePost
        {
            get;
            set;
        }
    }
}