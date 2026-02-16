#!/usr/bin/env zsh

cd "${0:A:h}" || exit 1

rm -rf .openapi-generator api docs src

openapi-generator-cli generate --config ./LeanCode.Kratos.Client.json

sed -Ei '/Date[A-Za-z]+JsonConverter/d' src/LeanCode.Kratos.Client/Client/HostConfiguration.cs

find src -name '*.cs' -exec sed -Ei 's/utf8JsonReader\.TokenType == JsonTokenType\.Null \? \(Guid\?\)null : utf8JsonReader\.GetGuid\(\)/utf8JsonReader.GetString()/g' '{}' +

patch -Np1 -i oneof.diff

cat > src/LeanCode.Kratos.Client/Client/NullTokenProvider.cs <<'EOF'
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
EOF