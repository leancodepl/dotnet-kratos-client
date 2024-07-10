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
    /// Update Login Flow with TOTP Method
    /// </summary>
    public partial class KratosUpdateLoginFlowWithTotpMethod
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosUpdateLoginFlowWithTotpMethod" /> class.
        /// </summary>
        /// <param name="method">Method should be set to \&quot;totp\&quot; when logging in using the TOTP strategy.</param>
        /// <param name="totpCode">The TOTP code.</param>
        /// <param name="csrfToken">Sending the anti-csrf token is only required for browser login flows.</param>
        /// <param name="transientPayload">Transient data to pass along to any webhooks</param>
        [JsonConstructor]
        public KratosUpdateLoginFlowWithTotpMethod(string method, string totpCode, Option<string?> csrfToken = default, Option<Object?> transientPayload = default)
        {
            Method = method;
            TotpCode = totpCode;
            CsrfTokenOption = csrfToken;
            TransientPayloadOption = transientPayload;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Method should be set to \&quot;totp\&quot; when logging in using the TOTP strategy.
        /// </summary>
        /// <value>Method should be set to \&quot;totp\&quot; when logging in using the TOTP strategy.</value>
        [JsonPropertyName("method")]
        public string Method { get; set; }

        /// <summary>
        /// The TOTP code.
        /// </summary>
        /// <value>The TOTP code.</value>
        [JsonPropertyName("totp_code")]
        public string TotpCode { get; set; }

        /// <summary>
        /// Used to track the state of CsrfToken
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> CsrfTokenOption { get; private set; }

        /// <summary>
        /// Sending the anti-csrf token is only required for browser login flows.
        /// </summary>
        /// <value>Sending the anti-csrf token is only required for browser login flows.</value>
        [JsonPropertyName("csrf_token")]
        public string? CsrfToken { get { return this.CsrfTokenOption; } set { this.CsrfTokenOption = new(value); } }

        /// <summary>
        /// Used to track the state of TransientPayload
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Object?> TransientPayloadOption { get; private set; }

        /// <summary>
        /// Transient data to pass along to any webhooks
        /// </summary>
        /// <value>Transient data to pass along to any webhooks</value>
        [JsonPropertyName("transient_payload")]
        public Object? TransientPayload { get { return this.TransientPayloadOption; } set { this.TransientPayloadOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class KratosUpdateLoginFlowWithTotpMethod {\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  TotpCode: ").Append(TotpCode).Append("\n");
            sb.Append("  CsrfToken: ").Append(CsrfToken).Append("\n");
            sb.Append("  TransientPayload: ").Append(TransientPayload).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="KratosUpdateLoginFlowWithTotpMethod" />
    /// </summary>
    public class KratosUpdateLoginFlowWithTotpMethodJsonConverter : JsonConverter<KratosUpdateLoginFlowWithTotpMethod>
    {
        /// <summary>
        /// Deserializes json to <see cref="KratosUpdateLoginFlowWithTotpMethod" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override KratosUpdateLoginFlowWithTotpMethod Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> method = default;
            Option<string?> totpCode = default;
            Option<string?> csrfToken = default;
            Option<Object?> transientPayload = default;

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
                        case "method":
                            method = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "totp_code":
                            totpCode = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "csrf_token":
                            csrfToken = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "transient_payload":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                transientPayload = new Option<Object?>(JsonSerializer.Deserialize<Object>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!method.IsSet)
                throw new ArgumentException("Property is required for class KratosUpdateLoginFlowWithTotpMethod.", nameof(method));

            if (!totpCode.IsSet)
                throw new ArgumentException("Property is required for class KratosUpdateLoginFlowWithTotpMethod.", nameof(totpCode));

            if (method.IsSet && method.Value == null)
                throw new ArgumentNullException(nameof(method), "Property is not nullable for class KratosUpdateLoginFlowWithTotpMethod.");

            if (totpCode.IsSet && totpCode.Value == null)
                throw new ArgumentNullException(nameof(totpCode), "Property is not nullable for class KratosUpdateLoginFlowWithTotpMethod.");

            if (csrfToken.IsSet && csrfToken.Value == null)
                throw new ArgumentNullException(nameof(csrfToken), "Property is not nullable for class KratosUpdateLoginFlowWithTotpMethod.");

            if (transientPayload.IsSet && transientPayload.Value == null)
                throw new ArgumentNullException(nameof(transientPayload), "Property is not nullable for class KratosUpdateLoginFlowWithTotpMethod.");

            return new KratosUpdateLoginFlowWithTotpMethod(method.Value!, totpCode.Value!, csrfToken, transientPayload);
        }

        /// <summary>
        /// Serializes a <see cref="KratosUpdateLoginFlowWithTotpMethod" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosUpdateLoginFlowWithTotpMethod"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, KratosUpdateLoginFlowWithTotpMethod kratosUpdateLoginFlowWithTotpMethod, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, kratosUpdateLoginFlowWithTotpMethod, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="KratosUpdateLoginFlowWithTotpMethod" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosUpdateLoginFlowWithTotpMethod"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, KratosUpdateLoginFlowWithTotpMethod kratosUpdateLoginFlowWithTotpMethod, JsonSerializerOptions jsonSerializerOptions)
        {
            if (kratosUpdateLoginFlowWithTotpMethod.Method == null)
                throw new ArgumentNullException(nameof(kratosUpdateLoginFlowWithTotpMethod.Method), "Property is required for class KratosUpdateLoginFlowWithTotpMethod.");

            if (kratosUpdateLoginFlowWithTotpMethod.TotpCode == null)
                throw new ArgumentNullException(nameof(kratosUpdateLoginFlowWithTotpMethod.TotpCode), "Property is required for class KratosUpdateLoginFlowWithTotpMethod.");

            if (kratosUpdateLoginFlowWithTotpMethod.CsrfTokenOption.IsSet && kratosUpdateLoginFlowWithTotpMethod.CsrfToken == null)
                throw new ArgumentNullException(nameof(kratosUpdateLoginFlowWithTotpMethod.CsrfToken), "Property is required for class KratosUpdateLoginFlowWithTotpMethod.");

            if (kratosUpdateLoginFlowWithTotpMethod.TransientPayloadOption.IsSet && kratosUpdateLoginFlowWithTotpMethod.TransientPayload == null)
                throw new ArgumentNullException(nameof(kratosUpdateLoginFlowWithTotpMethod.TransientPayload), "Property is required for class KratosUpdateLoginFlowWithTotpMethod.");

            writer.WriteString("method", kratosUpdateLoginFlowWithTotpMethod.Method);

            writer.WriteString("totp_code", kratosUpdateLoginFlowWithTotpMethod.TotpCode);

            if (kratosUpdateLoginFlowWithTotpMethod.CsrfTokenOption.IsSet)
                writer.WriteString("csrf_token", kratosUpdateLoginFlowWithTotpMethod.CsrfToken);

            if (kratosUpdateLoginFlowWithTotpMethod.TransientPayloadOption.IsSet)
            {
                writer.WritePropertyName("transient_payload");
                JsonSerializer.Serialize(writer, kratosUpdateLoginFlowWithTotpMethod.TransientPayload, jsonSerializerOptions);
            }
        }
    }
}