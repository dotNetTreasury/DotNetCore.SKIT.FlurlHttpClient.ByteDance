﻿using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.OpenApi.Models
{
    /// <summary>
    /// <para>表示 [POST] /v1/microapp/app/del_categories 接口的请求。</para>
    /// </summary>
    public class OpenApiMicroAppAppDeleteCategoriesV1Request : ByteDanceMicroAppOpenApiRequest
    {
        /// <summary>
        /// 获取或设置服务类目 ID 字符串（以逗号分隔）列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("categories")]
        [System.Text.Json.Serialization.JsonPropertyName("categories")]
        public IList<string> CategoryIdStringList { get; set; } = new List<string>();
    }
}
