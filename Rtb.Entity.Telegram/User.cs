using Newtonsoft.Json;

namespace Rtb.Entity.Telegram
{
    /// <summary>
    /// Telegram object User
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class User
    {
        /// <summary>
        /// User identity
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// User first name
        /// </summary>
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// User last name
        /// </summary>
        [JsonProperty("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// User name in telegram (@test_user)
        /// </summary>
        [JsonProperty("user_name")]
        public string UserName { get; set; }
    }
}