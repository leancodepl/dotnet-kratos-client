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
    /// KratosIdentityWithCredentialsOidcConfig
    /// </summary>
    public partial class KratosIdentityWithCredentialsOidcConfig
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosIdentityWithCredentialsOidcConfig" /> class.
        /// </summary>
        /// <param name="config">config</param>
        /// <param name="providers">A list of OpenID Connect Providers</param>
        [JsonConstructor]
        public KratosIdentityWithCredentialsOidcConfig(Option<KratosIdentityWithCredentialsPasswordConfig?> config = default, Option<List<KratosIdentityWithCredentialsOidcConfigProvider>?> providers = default)
        {
            ConfigOption = config;
            ProvidersOption = providers;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Config
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<KratosIdentityWithCredentialsPasswordConfig?> ConfigOption { get; private set; }

        /// <summary>
        /// Gets or Sets Config
        /// </summary>
        [JsonPropertyName("config")]
        public KratosIdentityWithCredentialsPasswordConfig? Config { get { return this.ConfigOption; } set { this.ConfigOption = new(value); } }

        /// <summary>
        /// Used to track the state of Providers
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<KratosIdentityWithCredentialsOidcConfigProvider>?> ProvidersOption { get; private set; }

        /// <summary>
        /// A list of OpenID Connect Providers
        /// </summary>
        /// <value>A list of OpenID Connect Providers</value>
        [JsonPropertyName("providers")]
        public List<KratosIdentityWithCredentialsOidcConfigProvider>? Providers { get { return this.ProvidersOption; } set { this.ProvidersOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class KratosIdentityWithCredentialsOidcConfig {\n");
            sb.Append("  Config: ").Append(Config).Append("\n");
            sb.Append("  Providers: ").Append(Providers).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="KratosIdentityWithCredentialsOidcConfig" />
    /// </summary>
    public class KratosIdentityWithCredentialsOidcConfigJsonConverter : JsonConverter<KratosIdentityWithCredentialsOidcConfig>
    {
        /// <summary>
        /// Deserializes json to <see cref="KratosIdentityWithCredentialsOidcConfig" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override KratosIdentityWithCredentialsOidcConfig Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<KratosIdentityWithCredentialsPasswordConfig?> config = default;
            Option<List<KratosIdentityWithCredentialsOidcConfigProvider>?> providers = default;

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
                        case "config":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                config = new Option<KratosIdentityWithCredentialsPasswordConfig?>(JsonSerializer.Deserialize<KratosIdentityWithCredentialsPasswordConfig>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "providers":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                providers = new Option<List<KratosIdentityWithCredentialsOidcConfigProvider>?>(JsonSerializer.Deserialize<List<KratosIdentityWithCredentialsOidcConfigProvider>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (config.IsSet && config.Value == null)
                throw new ArgumentNullException(nameof(config), "Property is not nullable for class KratosIdentityWithCredentialsOidcConfig.");

            if (providers.IsSet && providers.Value == null)
                throw new ArgumentNullException(nameof(providers), "Property is not nullable for class KratosIdentityWithCredentialsOidcConfig.");

            return new KratosIdentityWithCredentialsOidcConfig(config, providers);
        }

        /// <summary>
        /// Serializes a <see cref="KratosIdentityWithCredentialsOidcConfig" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosIdentityWithCredentialsOidcConfig"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, KratosIdentityWithCredentialsOidcConfig kratosIdentityWithCredentialsOidcConfig, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, kratosIdentityWithCredentialsOidcConfig, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="KratosIdentityWithCredentialsOidcConfig" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosIdentityWithCredentialsOidcConfig"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, KratosIdentityWithCredentialsOidcConfig kratosIdentityWithCredentialsOidcConfig, JsonSerializerOptions jsonSerializerOptions)
        {
            if (kratosIdentityWithCredentialsOidcConfig.ConfigOption.IsSet && kratosIdentityWithCredentialsOidcConfig.Config == null)
                throw new ArgumentNullException(nameof(kratosIdentityWithCredentialsOidcConfig.Config), "Property is required for class KratosIdentityWithCredentialsOidcConfig.");

            if (kratosIdentityWithCredentialsOidcConfig.ProvidersOption.IsSet && kratosIdentityWithCredentialsOidcConfig.Providers == null)
                throw new ArgumentNullException(nameof(kratosIdentityWithCredentialsOidcConfig.Providers), "Property is required for class KratosIdentityWithCredentialsOidcConfig.");

            if (kratosIdentityWithCredentialsOidcConfig.ConfigOption.IsSet)
            {
                writer.WritePropertyName("config");
                JsonSerializer.Serialize(writer, kratosIdentityWithCredentialsOidcConfig.Config, jsonSerializerOptions);
            }
            if (kratosIdentityWithCredentialsOidcConfig.ProvidersOption.IsSet)
            {
                writer.WritePropertyName("providers");
                JsonSerializer.Serialize(writer, kratosIdentityWithCredentialsOidcConfig.Providers, jsonSerializerOptions);
            }
        }
    }
}