namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [GET] /apps/v1/capacity/query_subscribe_notification_tpl_list 接口的响应。</para>
    /// </summary>
    public class AppsCapacityQuerySubscribeNotificationTemplateListV1Response : ByteDanceMicroAppResponse
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Template
                    {
                        /// <summary>
                        /// 获取或设置模板 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("template_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("template_id")]
                        public long TemplateId { get; set; }

                        /// <summary>
                        /// 获取或设置订阅消息类型。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("classification")]
                        [System.Text.Json.Serialization.JsonPropertyName("classification")]
                        public int Classification { get; set; }

                        /// <summary>
                        /// 获取或设置模版标题。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("title")]
                        [System.Text.Json.Serialization.JsonPropertyName("title")]
                        public string Title { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置模版关键字列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("keyword_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("keyword_list")]
                        public string[] KeywordList { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置类目名称字符串（以斜线分隔）。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("category_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("category_name")]
                        public string CategoryNameString { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置宿主名称列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("host_list")]
                        [System.Text.Json.Serialization.JsonPropertyName("host_list")]
                        public string[] HostNameList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置订阅消息模版列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("template_list")]
                [System.Text.Json.Serialization.JsonPropertyName("template_list")]
                public Types.Template[] TemplateList { get; set; } = default!;

                /// <summary>
                /// 获取或设置总数量。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("total_count")]
                [System.Text.Json.Serialization.JsonPropertyName("total_count")]
                public int TotalCount { get; set; }
            }
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("err_no")]
        [System.Text.Json.Serialization.JsonPropertyName("err_no")]
        public override long ErrorCode { get; set; }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        [Newtonsoft.Json.JsonProperty("err_msg")]
        [System.Text.Json.Serialization.JsonPropertyName("err_msg")]
        public override string? ErrorMessage { get; set; }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
