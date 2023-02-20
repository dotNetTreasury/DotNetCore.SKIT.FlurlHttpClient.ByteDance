namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /product/api/sync_callback_url 接口的请求。</para>
    /// </summary>
    public class ProductApiSyncCallbackUrlRequest : ByteDanceMicroAppRequest
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("access_token")]
        [System.Text.Json.Serialization.JsonPropertyName("access_token")]
        public override string? AccessToken { get; set; }

        /// <summary>
        /// 获取或设置小程序的 AppId。如果不指定将使用构造 <see cref="ByteDanceMicroAppClient"/> 时的 <see cref="ByteDanceMicroAppClientOptions.AppId"/> 参数。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("appid")]
        [System.Text.Json.Serialization.JsonPropertyName("appid")]
        public string? AppId { get; set; }

        /// <summary>
        /// 获取或设置接受通知的 URL。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("callback_url")]
        [System.Text.Json.Serialization.JsonPropertyName("callback_url")]
        public string CallbackUrl { get; set; } = string.Empty;

        /// <summary>
        /// 获取或设置确认通知方身份唯一标识。</para>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("developer_flag")]
        [System.Text.Json.Serialization.JsonPropertyName("developer_flag")]
        public string DeveloperFlag { get; set; } = string.Empty;
    }
}