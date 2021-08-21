﻿using System;
using System.Collections.Generic;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/brandList 接口的请求。</para>
    /// </summary>
    public class ShopBandListRequest : TikTokShopRequest
    {
        protected internal override string GetMethod()
        {
            return string.Intern("shop.brandList");
        }
    }
}