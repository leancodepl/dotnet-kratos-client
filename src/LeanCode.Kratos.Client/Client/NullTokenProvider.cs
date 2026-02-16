using System;
using System.Collections.Specialized;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace LeanCode.Kratos.Client.Client;

#pragma warning disable CS1591

public class NullTokenProvider() : TokenProvider<ApiKeyToken>([new NullApiKeyToken()])
{
    public static NullTokenProvider Instance { get; } = new();

    protected internal override ValueTask<ApiKeyToken> GetAsync(
        string header = "",
        CancellationToken cancellation = default
    ) => new(_tokens[0]);

    private sealed class NullApiKeyToken() : ApiKeyToken(string.Empty, default, string.Empty)
    {
        public override void UseInHeader(HttpRequestMessage request) { }

        public override void UseInQuery(
            HttpRequestMessage request,
            UriBuilder uriBuilder,
            NameValueCollection parseQueryString
        ) { }
    }
}
