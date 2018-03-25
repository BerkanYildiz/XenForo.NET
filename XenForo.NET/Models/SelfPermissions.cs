namespace XenForo.NET.Models
{
    using Newtonsoft.Json;

    public class SelfPermissions
    {
        [JsonProperty("create_conversation")]
        public bool CreateConversation
        {
            get;
            set;
        }

        [JsonProperty("upload_attachment_conversation")]
        public bool UploadAttachmentConversation
        {
            get;
            set;
        }
    }
}