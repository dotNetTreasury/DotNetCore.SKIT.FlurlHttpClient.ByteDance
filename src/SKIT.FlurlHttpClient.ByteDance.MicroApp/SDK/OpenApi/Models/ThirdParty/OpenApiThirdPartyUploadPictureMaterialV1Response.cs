namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /v1/tp/upload_pic_material 接口的响应。</para>
    /// </summary>
    public class OpenApiThirdPartyUploadPictureMaterialV1Response : ByteDanceMicroAppOpenApiResponse
    {
        public static class Types
        {
            public class Data
            {
                /// <summary>
                /// 获取或设置文件路径。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("path")]
                [System.Text.Json.Serialization.JsonPropertyName("path")]
                public string FilePath { get; set; } = default!;
            }
        }

        /// <summary>
        /// 获取或设置返回数据。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("data")]
        [System.Text.Json.Serialization.JsonPropertyName("data")]
        public Types.Data Data { get; set; } = default!;
    }
}
