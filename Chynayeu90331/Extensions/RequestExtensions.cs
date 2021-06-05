﻿using Microsoft.AspNetCore.Http;

namespace Chynayeu90331.Extensions
{
    public static class RequestExtensions
    {
        public static bool IsAjaxRequest(this HttpRequest request)
        {
            return request.Headers["x-requested-with"]
           .Equals("XMLHttpRequest");
        }
    }
}
