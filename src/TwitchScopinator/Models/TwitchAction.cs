using System.Text.Json.Serialization;

namespace TwitchScopinator.Models
{
    public class TwitchAction
    {
        // Chat
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("scopes")]
        public string[]? Scopes { get; set; }

        [JsonPropertyName("link")]
        public string? Link { get; set; }
    }

    public class RestAction : TwitchAction
    {
        [JsonPropertyName("category")]
        public string? Category { get; set; }
        [JsonPropertyName("allow_app_auth")]
        public bool? AllowsAppAuth { get; set; }
    }

    public class EventSubAction : RestAction
    {
        [JsonPropertyName("version")]
        public string? Version { get; set; }

        [JsonPropertyName("scope_required")]
        public bool? IsScopeRequired { get; set; }
    }
}
