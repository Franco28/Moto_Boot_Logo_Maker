
using System;
using System.Net;

namespace AutoUpdaterDotNET
{
    public class MyWebClient : WebClient
    {
        public Uri ResponseUri;

        protected override WebResponse GetWebResponse(WebRequest request, IAsyncResult result)
        {
            WebResponse webResponse = base.GetWebResponse(request, result);
            ResponseUri = webResponse.ResponseUri;
            return webResponse;
        }
    }
}
