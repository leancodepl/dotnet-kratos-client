using System;
using System.Collections.Specialized;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace LeanCode.Kratos.Client.Client;

#pragma warning disable CS1591

public class NullTokenProvider : TokenProvider<ApiKeyToken>
{
    public static NullTokenProvider Instance { get; } = new();

    public NullTokenProvider()
        : base(new[] { new NullApiKeyToken() }) { }

    internal override ValueTask<ApiKeyToken> GetAsync(string header = "", CancellationToken cancellation = default) =>
        new(_tokens[0]);

    private sealed class NullApiKeyToken : ApiKeyToken
    {
        public NullApiKeyToken()
            : base(string.Empty, default) { }

        public override void UseInHeader(HttpRequestMessage request) { }

        public override void UseInQuery(
            HttpRequestMessage request,
            UriBuilder uriBuilder,
            NameValueCollection parseQueryString
        ) { }
    }
}
