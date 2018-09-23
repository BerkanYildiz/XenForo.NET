namespace XenForo.NET
{
    using System;
    using System.Threading.Tasks;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    using RestSharp;

    using XenForo.NET.Models;

    public partial class XenforoApi
    {
        /// <summary>
        /// Gets the user.
        /// </summary>
        /// <param name="Identifier">The identifier.</param>
        public User GetUser(int Identifier = -1)
        {
            if (Identifier == -1)
            {
                if (this.IsAuthenticated == false)
                {
                    throw new Exception("Identifier can't be -1 if the client is not authenticated.");
                }

                Identifier  = this.GetVisitorId();

                if (Identifier == -1)
                {
                    throw new Exception("Identifier == -1 after the check.");
                }
            }

            var User        = (User) null;
            var Request     = new RestRequest("?users/{userId}").AddUrlSegment("userId", Identifier.ToString());
            var Response    = this.Client.Get(Request);

            if (Response.IsSuccessful)
            {
                var Json = JObject.Parse(Response.Content);

                if (Json != null && Json.HasValues)
                {
                    if (Json.ContainsKey("user"))
                    {
                        User = JsonConvert.DeserializeObject<User>(Json["user"].ToString());
                    }
                }
            }

            return User;
        }

        /// <summary>
        /// Gets the user.
        /// </summary>
        /// <param name="Identifier">The identifier.</param>
        public async Task<User> GetUserAsync(int Identifier = -1)
        {
            if (Identifier == -1)
            {
                if (this.IsAuthenticated == false)
                {
                    throw new Exception("Identifier can't be -1 if the client is not authenticated.");
                }

                Identifier  = this.GetVisitorId();

                if (Identifier == -1)
                {
                    throw new Exception("Identifier == -1 after the check.");
                }
            }

            var User        = (User) null;
            var Request     = new RestRequest("?users/{userId}").AddUrlSegment("userId", Identifier.ToString());
            var Response    = await this.Client.ExecuteGetTaskAsync(Request);

            if (Response.IsSuccessful)
            {
                var Json = JObject.Parse(Response.Content);

                if (Json != null && Json.HasValues)
                {
                    if (Json.ContainsKey("user"))
                    {
                        User = JsonConvert.DeserializeObject<User>(Json["user"].ToString());
                    }
                }
            }

            return User;
        }
    }
}