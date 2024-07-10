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
    /// Update Login Flow with WebAuthn Method
    /// </summary>
    public partial class KratosUpdateLoginFlowWithWebAuthnMethod
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosUpdateLoginFlowWithWebAuthnMethod" /> class.
        /// </summary>
        /// <param name="identifier">Identifier is the email or username of the user trying to log in.</param>
        /// <param name="method">Method should be set to \&quot;webAuthn\&quot; when logging in using the WebAuthn strategy.</param>
        /// <param name="csrfToken">Sending the anti-csrf token is only required for browser login flows.</param>
        /// <param name="transientPayload">Transient data to pass along to any webhooks</param>
        /// <param name="webauthnLogin">Login a WebAuthn Security Key  This must contain the ID of the WebAuthN connection.</param>
        [JsonConstructor]
        public KratosUpdateLoginFlowWithWebAuthnMethod(string identifier, string method, Option<string?> csrfToken = default, Option<Object?> transientPayload = default, Option<string?> webauthnLogin = default)
        {
            Identifier = identifier;
            Method = method;
            CsrfTokenOption = csrfToken;
            TransientPayloadOption = transientPayload;
            WebauthnLoginOption = webauthnLogin;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Identifier is the email or username of the user trying to log in.
        /// </summary>
        /// <value>Identifier is the email or username of the user trying to log in.</value>
        [JsonPropertyName("identifier")]
        public string Identifier { get; set; }

        /// <summary>
        /// Method should be set to \&quot;webAuthn\&quot; when logging in using the WebAuthn strategy.
        /// </summary>
        /// <value>Method should be set to \&quot;webAuthn\&quot; when logging in using the WebAuthn strategy.</value>
        [JsonPropertyName("method")]
        public string Method { get; set; }

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
        /// Used to track the state of WebauthnLogin
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> WebauthnLoginOption { get; private set; }

        /// <summary>
        /// Login a WebAuthn Security Key  This must contain the ID of the WebAuthN connection.
        /// </summary>
        /// <value>Login a WebAuthn Security Key  This must contain the ID of the WebAuthN connection.</value>
        [JsonPropertyName("webauthn_login")]
        public string? WebauthnLogin { get { return this.WebauthnLoginOption; } set { this.WebauthnLoginOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class KratosUpdateLoginFlowWithWebAuthnMethod {\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  CsrfToken: ").Append(CsrfToken).Append("\n");
            sb.Append("  TransientPayload: ").Append(TransientPayload).Append("\n");
            sb.Append("  WebauthnLogin: ").Append(WebauthnLogin).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="KratosUpdateLoginFlowWithWebAuthnMethod" />
    /// </summary>
    public class KratosUpdateLoginFlowWithWebAuthnMethodJsonConverter : JsonConverter<KratosUpdateLoginFlowWithWebAuthnMethod>
    {
        /// <summary>
        /// Deserializes json to <see cref="KratosUpdateLoginFlowWithWebAuthnMethod" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override KratosUpdateLoginFlowWithWebAuthnMethod Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> identifier = default;
            Option<string?> method = default;
            Option<string?> csrfToken = default;
            Option<Object?> transientPayload = default;
            Option<string?> webauthnLogin = default;

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
                        case "identifier":
                            identifier = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "method":
                            method = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "csrf_token":
                            csrfToken = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "transient_payload":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                transientPayload = new Option<Object?>(JsonSerializer.Deserialize<Object>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "webauthn_login":
                            webauthnLogin = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!identifier.IsSet)
                throw new ArgumentException("Property is required for class KratosUpdateLoginFlowWithWebAuthnMethod.", nameof(identifier));

            if (!method.IsSet)
                throw new ArgumentException("Property is required for class KratosUpdateLoginFlowWithWebAuthnMethod.", nameof(method));

            if (identifier.IsSet && identifier.Value == null)
                throw new ArgumentNullException(nameof(identifier), "Property is not nullable for class KratosUpdateLoginFlowWithWebAuthnMethod.");

            if (method.IsSet && method.Value == null)
                throw new ArgumentNullException(nameof(method), "Property is not nullable for class KratosUpdateLoginFlowWithWebAuthnMethod.");

            if (csrfToken.IsSet && csrfToken.Value == null)
                throw new ArgumentNullException(nameof(csrfToken), "Property is not nullable for class KratosUpdateLoginFlowWithWebAuthnMethod.");

            if (transientPayload.IsSet && transientPayload.Value == null)
                throw new ArgumentNullException(nameof(transientPayload), "Property is not nullable for class KratosUpdateLoginFlowWithWebAuthnMethod.");

            if (webauthnLogin.IsSet && webauthnLogin.Value == null)
                throw new ArgumentNullException(nameof(webauthnLogin), "Property is not nullable for class KratosUpdateLoginFlowWithWebAuthnMethod.");

            return new KratosUpdateLoginFlowWithWebAuthnMethod(identifier.Value!, method.Value!, csrfToken, transientPayload, webauthnLogin);
        }

        /// <summary>
        /// Serializes a <see cref="KratosUpdateLoginFlowWithWebAuthnMethod" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosUpdateLoginFlowWithWebAuthnMethod"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, KratosUpdateLoginFlowWithWebAuthnMethod kratosUpdateLoginFlowWithWebAuthnMethod, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, kratosUpdateLoginFlowWithWebAuthnMethod, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="KratosUpdateLoginFlowWithWebAuthnMethod" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosUpdateLoginFlowWithWebAuthnMethod"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, KratosUpdateLoginFlowWithWebAuthnMethod kratosUpdateLoginFlowWithWebAuthnMethod, JsonSerializerOptions jsonSerializerOptions)
        {
            if (kratosUpdateLoginFlowWithWebAuthnMethod.Identifier == null)
                throw new ArgumentNullException(nameof(kratosUpdateLoginFlowWithWebAuthnMethod.Identifier), "Property is required for class KratosUpdateLoginFlowWithWebAuthnMethod.");

            if (kratosUpdateLoginFlowWithWebAuthnMethod.Method == null)
                throw new ArgumentNullException(nameof(kratosUpdateLoginFlowWithWebAuthnMethod.Method), "Property is required for class KratosUpdateLoginFlowWithWebAuthnMethod.");

            if (kratosUpdateLoginFlowWithWebAuthnMethod.CsrfTokenOption.IsSet && kratosUpdateLoginFlowWithWebAuthnMethod.CsrfToken == null)
                throw new ArgumentNullException(nameof(kratosUpdateLoginFlowWithWebAuthnMethod.CsrfToken), "Property is required for class KratosUpdateLoginFlowWithWebAuthnMethod.");

            if (kratosUpdateLoginFlowWithWebAuthnMethod.TransientPayloadOption.IsSet && kratosUpdateLoginFlowWithWebAuthnMethod.TransientPayload == null)
                throw new ArgumentNullException(nameof(kratosUpdateLoginFlowWithWebAuthnMethod.TransientPayload), "Property is required for class KratosUpdateLoginFlowWithWebAuthnMethod.");

            if (kratosUpdateLoginFlowWithWebAuthnMethod.WebauthnLoginOption.IsSet && kratosUpdateLoginFlowWithWebAuthnMethod.WebauthnLogin == null)
                throw new ArgumentNullException(nameof(kratosUpdateLoginFlowWithWebAuthnMethod.WebauthnLogin), "Property is required for class KratosUpdateLoginFlowWithWebAuthnMethod.");

            writer.WriteString("identifier", kratosUpdateLoginFlowWithWebAuthnMethod.Identifier);

            writer.WriteString("method", kratosUpdateLoginFlowWithWebAuthnMethod.Method);

            if (kratosUpdateLoginFlowWithWebAuthnMethod.CsrfTokenOption.IsSet)
                writer.WriteString("csrf_token", kratosUpdateLoginFlowWithWebAuthnMethod.CsrfToken);

            if (kratosUpdateLoginFlowWithWebAuthnMethod.TransientPayloadOption.IsSet)
            {
                writer.WritePropertyName("transient_payload");
                JsonSerializer.Serialize(writer, kratosUpdateLoginFlowWithWebAuthnMethod.TransientPayload, jsonSerializerOptions);
            }
            if (kratosUpdateLoginFlowWithWebAuthnMethod.WebauthnLoginOption.IsSet)
                writer.WriteString("webauthn_login", kratosUpdateLoginFlowWithWebAuthnMethod.WebauthnLogin);
        }
    }
}