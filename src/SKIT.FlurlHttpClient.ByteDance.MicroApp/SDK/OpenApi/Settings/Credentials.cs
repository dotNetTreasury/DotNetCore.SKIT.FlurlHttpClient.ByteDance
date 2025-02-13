using System;

namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.SDK.OpenApi.Settings
{
    public class Credentials
    {
        /// <summary>
        /// 初始化客户端时 <see cref="ByteDanceMicroAppOpenApiClientOptions.ComponentAppId"/> 的副本。
        /// </summary>
        public string ComponentAppId { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="ByteDanceMicroAppOpenApiClientOptions.ComponentAppSecret"/> 的副本。
        /// </summary>
        public string ComponentAppSecret { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="ByteDanceMicroAppClientOptions.PushToken"/> 的副本。
        /// </summary>
        public string? PushToken { get; }

        /// <summary>
        /// 初始化客户端时 <see cref="ByteDanceMicroAppClientOptions.PushEncodingAESKey"/> 的副本。
        /// </summary>
        public string? PushEncodingAESKey { get; set; }

        internal Credentials(ByteDanceMicroAppOpenApiClientOptions options)
        {
            if (options == null) throw new ArgumentNullException(nameof(options));

            ComponentAppId = options.ComponentAppId;
            ComponentAppSecret = options.ComponentAppSecret;
            PushToken = options.PushToken;
            PushEncodingAESKey = options.PushEncodingAESKey;
        }
    }
}
