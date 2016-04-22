using Newtonsoft.Json;

namespace Rtb.Entity.Telegram
{
    /// <summary>
    /// Telegram object Messaage
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class Message
    {
        /// <summary>
        /// Message identity
        /// </summary>
        [JsonProperty("message_id")]
        public int Id { get; set; }

        /// <summary>
        /// User sended message
        /// </summary>
        [JsonProperty("from")]
        public User From { get; set; }

        /// <summary>
        /// Chat message
        /// </summary>
        [JsonProperty("chat")]
        public Chat Chat { get; set; }

        /// <summary>
        /// Message text
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }
    }
}