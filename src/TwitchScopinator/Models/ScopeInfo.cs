using System.Text.Json.Serialization;

namespace TwitchScopinator.Models
{
    public class ScopeInfo
    {
        [JsonPropertyName("rest")]
        public List<RestAction> Rest { get; set; } = new();

        [JsonPropertyName("chat")]
        public List<TwitchAction> Chat { get; set; } = new();

        [JsonPropertyName("pubsub")]
        public List<TwitchAction> PubSub { get; set; } = new();

        [JsonPropertyName("eventsub")]
        public List<EventSubAction> EventSub { get; set; } = new();
    }
}