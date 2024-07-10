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
    /// Create Recovery Link for Identity Request Body
    /// </summary>
    public partial class KratosCreateRecoveryLinkForIdentityBody
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosCreateRecoveryLinkForIdentityBody" /> class.
        /// </summary>
        /// <param name="identityId">Identity to Recover  The identity&#39;s ID you wish to recover.</param>
        /// <param name="expiresIn">Link Expires In  The recovery link will expire after that amount of time has passed. Defaults to the configuration value of &#x60;selfservice.methods.code.config.lifespan&#x60;.</param>
        [JsonConstructor]
        public KratosCreateRecoveryLinkForIdentityBody(string identityId, Option<string?> expiresIn = default)
        {
            IdentityId = identityId;
            ExpiresInOption = expiresIn;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Identity to Recover  The identity&#39;s ID you wish to recover.
        /// </summary>
        /// <value>Identity to Recover  The identity&#39;s ID you wish to recover.</value>
        [JsonPropertyName("identity_id")]
        public string IdentityId { get; set; }

        /// <summary>
        /// Used to track the state of ExpiresIn
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> ExpiresInOption { get; private set; }

        /// <summary>
        /// Link Expires In  The recovery link will expire after that amount of time has passed. Defaults to the configuration value of &#x60;selfservice.methods.code.config.lifespan&#x60;.
        /// </summary>
        /// <value>Link Expires In  The recovery link will expire after that amount of time has passed. Defaults to the configuration value of &#x60;selfservice.methods.code.config.lifespan&#x60;.</value>
        [JsonPropertyName("expires_in")]
        public string? ExpiresIn { get { return this.ExpiresInOption; } set { this.ExpiresInOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class KratosCreateRecoveryLinkForIdentityBody {\n");
            sb.Append("  IdentityId: ").Append(IdentityId).Append("\n");
            sb.Append("  ExpiresIn: ").Append(ExpiresIn).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="KratosCreateRecoveryLinkForIdentityBody" />
    /// </summary>
    public class KratosCreateRecoveryLinkForIdentityBodyJsonConverter : JsonConverter<KratosCreateRecoveryLinkForIdentityBody>
    {
        /// <summary>
        /// Deserializes json to <see cref="KratosCreateRecoveryLinkForIdentityBody" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override KratosCreateRecoveryLinkForIdentityBody Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> identityId = default;
            Option<string?> expiresIn = default;

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
                        case "identity_id":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                identityId = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "expires_in":
                            expiresIn = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!identityId.IsSet)
                throw new ArgumentException("Property is required for class KratosCreateRecoveryLinkForIdentityBody.", nameof(identityId));

            if (identityId.IsSet && identityId.Value == null)
                throw new ArgumentNullException(nameof(identityId), "Property is not nullable for class KratosCreateRecoveryLinkForIdentityBody.");

            if (expiresIn.IsSet && expiresIn.Value == null)
                throw new ArgumentNullException(nameof(expiresIn), "Property is not nullable for class KratosCreateRecoveryLinkForIdentityBody.");

            return new KratosCreateRecoveryLinkForIdentityBody(identityId.Value!, expiresIn);
        }

        /// <summary>
        /// Serializes a <see cref="KratosCreateRecoveryLinkForIdentityBody" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosCreateRecoveryLinkForIdentityBody"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, KratosCreateRecoveryLinkForIdentityBody kratosCreateRecoveryLinkForIdentityBody, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, kratosCreateRecoveryLinkForIdentityBody, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="KratosCreateRecoveryLinkForIdentityBody" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosCreateRecoveryLinkForIdentityBody"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, KratosCreateRecoveryLinkForIdentityBody kratosCreateRecoveryLinkForIdentityBody, JsonSerializerOptions jsonSerializerOptions)
        {
            if (kratosCreateRecoveryLinkForIdentityBody.IdentityId == null)
                throw new ArgumentNullException(nameof(kratosCreateRecoveryLinkForIdentityBody.IdentityId), "Property is required for class KratosCreateRecoveryLinkForIdentityBody.");

            if (kratosCreateRecoveryLinkForIdentityBody.ExpiresInOption.IsSet && kratosCreateRecoveryLinkForIdentityBody.ExpiresIn == null)
                throw new ArgumentNullException(nameof(kratosCreateRecoveryLinkForIdentityBody.ExpiresIn), "Property is required for class KratosCreateRecoveryLinkForIdentityBody.");

            writer.WriteString("identity_id", kratosCreateRecoveryLinkForIdentityBody.IdentityId);

            if (kratosCreateRecoveryLinkForIdentityBody.ExpiresInOption.IsSet)
                writer.WriteString("expires_in", kratosCreateRecoveryLinkForIdentityBody.ExpiresIn);
        }
    }
}