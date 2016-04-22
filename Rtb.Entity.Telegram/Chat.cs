using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Rtb.Entity.Telegram
{
    /// <summary>
    /// Telegram object Chat
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class Chat
    {
        /// <summary>
        /// Chat identity
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Chat type
        /// </summary>
        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public ChatType Type { get; set; }
    }
}