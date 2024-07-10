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
    /// Create Recovery Code for Identity Request Body
    /// </summary>
    public partial class KratosCreateRecoveryCodeForIdentityBody
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosCreateRecoveryCodeForIdentityBody" /> class.
        /// </summary>
        /// <param name="identityId">Identity to Recover  The identity&#39;s ID you wish to recover.</param>
        /// <param name="expiresIn">Code Expires In  The recovery code will expire after that amount of time has passed. Defaults to the configuration value of &#x60;selfservice.methods.code.config.lifespan&#x60;.</param>
        /// <param name="flowType">The flow type can either be &#x60;api&#x60; or &#x60;browser&#x60;.</param>
        [JsonConstructor]
        public KratosCreateRecoveryCodeForIdentityBody(string identityId, Option<string?> expiresIn = default, Option<string?> flowType = default)
        {
            IdentityId = identityId;
            ExpiresInOption = expiresIn;
            FlowTypeOption = flowType;
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
        /// Code Expires In  The recovery code will expire after that amount of time has passed. Defaults to the configuration value of &#x60;selfservice.methods.code.config.lifespan&#x60;.
        /// </summary>
        /// <value>Code Expires In  The recovery code will expire after that amount of time has passed. Defaults to the configuration value of &#x60;selfservice.methods.code.config.lifespan&#x60;.</value>
        [JsonPropertyName("expires_in")]
        public string? ExpiresIn { get { return this.ExpiresInOption; } set { this.ExpiresInOption = new(value); } }

        /// <summary>
        /// Used to track the state of FlowType
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> FlowTypeOption { get; private set; }

        /// <summary>
        /// The flow type can either be &#x60;api&#x60; or &#x60;browser&#x60;.
        /// </summary>
        /// <value>The flow type can either be &#x60;api&#x60; or &#x60;browser&#x60;.</value>
        [JsonPropertyName("flow_type")]
        public string? FlowType { get { return this.FlowTypeOption; } set { this.FlowTypeOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class KratosCreateRecoveryCodeForIdentityBody {\n");
            sb.Append("  IdentityId: ").Append(IdentityId).Append("\n");
            sb.Append("  ExpiresIn: ").Append(ExpiresIn).Append("\n");
            sb.Append("  FlowType: ").Append(FlowType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="KratosCreateRecoveryCodeForIdentityBody" />
    /// </summary>
    public class KratosCreateRecoveryCodeForIdentityBodyJsonConverter : JsonConverter<KratosCreateRecoveryCodeForIdentityBody>
    {
        /// <summary>
        /// Deserializes json to <see cref="KratosCreateRecoveryCodeForIdentityBody" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override KratosCreateRecoveryCodeForIdentityBody Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> identityId = default;
            Option<string?> expiresIn = default;
            Option<string?> flowType = default;

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
                        case "flow_type":
                            flowType = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!identityId.IsSet)
                throw new ArgumentException("Property is required for class KratosCreateRecoveryCodeForIdentityBody.", nameof(identityId));

            if (identityId.IsSet && identityId.Value == null)
                throw new ArgumentNullException(nameof(identityId), "Property is not nullable for class KratosCreateRecoveryCodeForIdentityBody.");

            if (expiresIn.IsSet && expiresIn.Value == null)
                throw new ArgumentNullException(nameof(expiresIn), "Property is not nullable for class KratosCreateRecoveryCodeForIdentityBody.");

            if (flowType.IsSet && flowType.Value == null)
                throw new ArgumentNullException(nameof(flowType), "Property is not nullable for class KratosCreateRecoveryCodeForIdentityBody.");

            return new KratosCreateRecoveryCodeForIdentityBody(identityId.Value!, expiresIn, flowType);
        }

        /// <summary>
        /// Serializes a <see cref="KratosCreateRecoveryCodeForIdentityBody" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosCreateRecoveryCodeForIdentityBody"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, KratosCreateRecoveryCodeForIdentityBody kratosCreateRecoveryCodeForIdentityBody, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, kratosCreateRecoveryCodeForIdentityBody, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="KratosCreateRecoveryCodeForIdentityBody" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosCreateRecoveryCodeForIdentityBody"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, KratosCreateRecoveryCodeForIdentityBody kratosCreateRecoveryCodeForIdentityBody, JsonSerializerOptions jsonSerializerOptions)
        {
            if (kratosCreateRecoveryCodeForIdentityBody.IdentityId == null)
                throw new ArgumentNullException(nameof(kratosCreateRecoveryCodeForIdentityBody.IdentityId), "Property is required for class KratosCreateRecoveryCodeForIdentityBody.");

            if (kratosCreateRecoveryCodeForIdentityBody.ExpiresInOption.IsSet && kratosCreateRecoveryCodeForIdentityBody.ExpiresIn == null)
                throw new ArgumentNullException(nameof(kratosCreateRecoveryCodeForIdentityBody.ExpiresIn), "Property is required for class KratosCreateRecoveryCodeForIdentityBody.");

            if (kratosCreateRecoveryCodeForIdentityBody.FlowTypeOption.IsSet && kratosCreateRecoveryCodeForIdentityBody.FlowType == null)
                throw new ArgumentNullException(nameof(kratosCreateRecoveryCodeForIdentityBody.FlowType), "Property is required for class KratosCreateRecoveryCodeForIdentityBody.");

            writer.WriteString("identity_id", kratosCreateRecoveryCodeForIdentityBody.IdentityId);

            if (kratosCreateRecoveryCodeForIdentityBody.ExpiresInOption.IsSet)
                writer.WriteString("expires_in", kratosCreateRecoveryCodeForIdentityBody.ExpiresIn);

            if (kratosCreateRecoveryCodeForIdentityBody.FlowTypeOption.IsSet)
                writer.WriteString("flow_type", kratosCreateRecoveryCodeForIdentityBody.FlowType);
        }
    }
}