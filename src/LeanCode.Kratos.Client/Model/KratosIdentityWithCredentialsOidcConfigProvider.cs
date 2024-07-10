// <auto-generated>
/*
 * Ory Identities API
 *
 * This is the API specification for Ory Identities with features such as registration, login, recovery, account verification, profile settings, password reset, identity management, session management, email and sms delivery, and more. 
 *
 * Contact: office@ory.sh
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using LeanCode.Kratos.Client.Client;

namespace LeanCode.Kratos.Client.Model
{
    /// <summary>
    /// Create Identity and Import Social Sign In Credentials Configuration
    /// </summary>
    public partial class KratosIdentityWithCredentialsOidcConfigProvider
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosIdentityWithCredentialsOidcConfigProvider" /> class.
        /// </summary>
        /// <param name="provider">The OpenID Connect provider to link the subject to. Usually something like &#x60;google&#x60; or &#x60;github&#x60;.</param>
        /// <param name="subject">The subject (&#x60;sub&#x60;) of the OpenID Connect connection. Usually the &#x60;sub&#x60; field of the ID Token.</param>
        [JsonConstructor]
        public KratosIdentityWithCredentialsOidcConfigProvider(string provider, string subject)
        {
            Provider = provider;
            Subject = subject;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// The OpenID Connect provider to link the subject to. Usually something like &#x60;google&#x60; or &#x60;github&#x60;.
        /// </summary>
        /// <value>The OpenID Connect provider to link the subject to. Usually something like &#x60;google&#x60; or &#x60;github&#x60;.</value>
        [JsonPropertyName("provider")]
        public string Provider { get; set; }

        /// <summary>
        /// The subject (&#x60;sub&#x60;) of the OpenID Connect connection. Usually the &#x60;sub&#x60; field of the ID Token.
        /// </summary>
        /// <value>The subject (&#x60;sub&#x60;) of the OpenID Connect connection. Usually the &#x60;sub&#x60; field of the ID Token.</value>
        [JsonPropertyName("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class KratosIdentityWithCredentialsOidcConfigProvider {\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="KratosIdentityWithCredentialsOidcConfigProvider" />
    /// </summary>
    public class KratosIdentityWithCredentialsOidcConfigProviderJsonConverter : JsonConverter<KratosIdentityWithCredentialsOidcConfigProvider>
    {
        /// <summary>
        /// Deserializes json to <see cref="KratosIdentityWithCredentialsOidcConfigProvider" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override KratosIdentityWithCredentialsOidcConfigProvider Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> provider = default;
            Option<string?> subject = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string? localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "provider":
                            provider = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "subject":
                            subject = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!provider.IsSet)
                throw new ArgumentException("Property is required for class KratosIdentityWithCredentialsOidcConfigProvider.", nameof(provider));

            if (!subject.IsSet)
                throw new ArgumentException("Property is required for class KratosIdentityWithCredentialsOidcConfigProvider.", nameof(subject));

            if (provider.IsSet && provider.Value == null)
                throw new ArgumentNullException(nameof(provider), "Property is not nullable for class KratosIdentityWithCredentialsOidcConfigProvider.");

            if (subject.IsSet && subject.Value == null)
                throw new ArgumentNullException(nameof(subject), "Property is not nullable for class KratosIdentityWithCredentialsOidcConfigProvider.");

            return new KratosIdentityWithCredentialsOidcConfigProvider(provider.Value!, subject.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="KratosIdentityWithCredentialsOidcConfigProvider" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosIdentityWithCredentialsOidcConfigProvider"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, KratosIdentityWithCredentialsOidcConfigProvider kratosIdentityWithCredentialsOidcConfigProvider, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, kratosIdentityWithCredentialsOidcConfigProvider, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="KratosIdentityWithCredentialsOidcConfigProvider" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosIdentityWithCredentialsOidcConfigProvider"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, KratosIdentityWithCredentialsOidcConfigProvider kratosIdentityWithCredentialsOidcConfigProvider, JsonSerializerOptions jsonSerializerOptions)
        {
            if (kratosIdentityWithCredentialsOidcConfigProvider.Provider == null)
                throw new ArgumentNullException(nameof(kratosIdentityWithCredentialsOidcConfigProvider.Provider), "Property is required for class KratosIdentityWithCredentialsOidcConfigProvider.");

            if (kratosIdentityWithCredentialsOidcConfigProvider.Subject == null)
                throw new ArgumentNullException(nameof(kratosIdentityWithCredentialsOidcConfigProvider.Subject), "Property is required for class KratosIdentityWithCredentialsOidcConfigProvider.");

            writer.WriteString("provider", kratosIdentityWithCredentialsOidcConfigProvider.Provider);

            writer.WriteString("subject", kratosIdentityWithCredentialsOidcConfigProvider.Subject);
        }
    }
}