namespace XenForo.NET.Models
{
    using Newtonsoft.Json;

    public class Links
    {
        [JsonProperty("avatar")]
        public string Avatar
        {
            get;
            set;
        }

        [JsonProperty("avatar_big")]
        public string AvatarBig
        {
            get;
            set;
        }

        [JsonProperty("avatar_small")]
        public string AvatarSmall
        {
            get;
            set;
        }

        [JsonProperty("details")]
        public string Details
        {
            get;
            set;
        }

        [JsonProperty("followers")]
        public string Followers
        {
            get;
            set;
        }

        [JsonProperty("followings")]
        public string Followings
        {
            get;
            set;
        }

        [JsonProperty("ignore")]
        public string Ignore
        {
            get;
            set;
        }

        [JsonProperty("permalink")]
        public string Permalink
        {
            get;
            set;
        }

        [JsonProperty("timeline")]
        public string Timeline
        {
            get;
            set;
        }
    }
}