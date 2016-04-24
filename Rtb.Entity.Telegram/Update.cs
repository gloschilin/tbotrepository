using Newtonsoft.Json;

namespace Rtb.Entity.Telegram
{

    /// <summary>
    /// Telegram object Update
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class Update
    {
        /// <summary>
        /// Update identity
        /// </summary>
        [JsonProperty("update_id")]
        public int UpdateId { get; set; }

        /// <summary>
        /// Messasge in update
        /// </summary>
        [JsonProperty("message")]
        public Message Message { get; set; }
    }
}
