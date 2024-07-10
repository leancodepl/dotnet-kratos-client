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
    /// Update Settings Flow with Lookup Method
    /// </summary>
    public partial class KratosUpdateSettingsFlowWithLookupMethod
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosUpdateSettingsFlowWithLookupMethod" /> class.
        /// </summary>
        /// <param name="method">Method  Should be set to \&quot;lookup\&quot; when trying to add, update, or remove a lookup pairing.</param>
        /// <param name="csrfToken">CSRFToken is the anti-CSRF token</param>
        /// <param name="lookupSecretConfirm">If set to true will save the regenerated lookup secrets</param>
        /// <param name="lookupSecretDisable">Disables this method if true.</param>
        /// <param name="lookupSecretRegenerate">If set to true will regenerate the lookup secrets</param>
        /// <param name="lookupSecretReveal">If set to true will reveal the lookup secrets</param>
        /// <param name="transientPayload">Transient data to pass along to any webhooks</param>
        [JsonConstructor]
        public KratosUpdateSettingsFlowWithLookupMethod(string method, Option<string?> csrfToken = default, Option<bool?> lookupSecretConfirm = default, Option<bool?> lookupSecretDisable = default, Option<bool?> lookupSecretRegenerate = default, Option<bool?> lookupSecretReveal = default, Option<Object?> transientPayload = default)
        {
            Method = method;
            CsrfTokenOption = csrfToken;
            LookupSecretConfirmOption = lookupSecretConfirm;
            LookupSecretDisableOption = lookupSecretDisable;
            LookupSecretRegenerateOption = lookupSecretRegenerate;
            LookupSecretRevealOption = lookupSecretReveal;
            TransientPayloadOption = transientPayload;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Method  Should be set to \&quot;lookup\&quot; when trying to add, update, or remove a lookup pairing.
        /// </summary>
        /// <value>Method  Should be set to \&quot;lookup\&quot; when trying to add, update, or remove a lookup pairing.</value>
        [JsonPropertyName("method")]
        public string Method { get; set; }

        /// <summary>
        /// Used to track the state of CsrfToken
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> CsrfTokenOption { get; private set; }

        /// <summary>
        /// CSRFToken is the anti-CSRF token
        /// </summary>
        /// <value>CSRFToken is the anti-CSRF token</value>
        [JsonPropertyName("csrf_token")]
        public string? CsrfToken { get { return this.CsrfTokenOption; } set { this.CsrfTokenOption = new(value); } }

        /// <summary>
        /// Used to track the state of LookupSecretConfirm
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> LookupSecretConfirmOption { get; private set; }

        /// <summary>
        /// If set to true will save the regenerated lookup secrets
        /// </summary>
        /// <value>If set to true will save the regenerated lookup secrets</value>
        [JsonPropertyName("lookup_secret_confirm")]
        public bool? LookupSecretConfirm { get { return this.LookupSecretConfirmOption; } set { this.LookupSecretConfirmOption = new(value); } }

        /// <summary>
        /// Used to track the state of LookupSecretDisable
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> LookupSecretDisableOption { get; private set; }

        /// <summary>
        /// Disables this method if true.
        /// </summary>
        /// <value>Disables this method if true.</value>
        [JsonPropertyName("lookup_secret_disable")]
        public bool? LookupSecretDisable { get { return this.LookupSecretDisableOption; } set { this.LookupSecretDisableOption = new(value); } }

        /// <summary>
        /// Used to track the state of LookupSecretRegenerate
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> LookupSecretRegenerateOption { get; private set; }

        /// <summary>
        /// If set to true will regenerate the lookup secrets
        /// </summary>
        /// <value>If set to true will regenerate the lookup secrets</value>
        [JsonPropertyName("lookup_secret_regenerate")]
        public bool? LookupSecretRegenerate { get { return this.LookupSecretRegenerateOption; } set { this.LookupSecretRegenerateOption = new(value); } }

        /// <summary>
        /// Used to track the state of LookupSecretReveal
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<bool?> LookupSecretRevealOption { get; private set; }

        /// <summary>
        /// If set to true will reveal the lookup secrets
        /// </summary>
        /// <value>If set to true will reveal the lookup secrets</value>
        [JsonPropertyName("lookup_secret_reveal")]
        public bool? LookupSecretReveal { get { return this.LookupSecretRevealOption; } set { this.LookupSecretRevealOption = new(value); } }

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
            sb.Append("class KratosUpdateSettingsFlowWithLookupMethod {\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  CsrfToken: ").Append(CsrfToken).Append("\n");
            sb.Append("  LookupSecretConfirm: ").Append(LookupSecretConfirm).Append("\n");
            sb.Append("  LookupSecretDisable: ").Append(LookupSecretDisable).Append("\n");
            sb.Append("  LookupSecretRegenerate: ").Append(LookupSecretRegenerate).Append("\n");
            sb.Append("  LookupSecretReveal: ").Append(LookupSecretReveal).Append("\n");
            sb.Append("  TransientPayload: ").Append(TransientPayload).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="KratosUpdateSettingsFlowWithLookupMethod" />
    /// </summary>
    public class KratosUpdateSettingsFlowWithLookupMethodJsonConverter : JsonConverter<KratosUpdateSettingsFlowWithLookupMethod>
    {
        /// <summary>
        /// Deserializes json to <see cref="KratosUpdateSettingsFlowWithLookupMethod" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override KratosUpdateSettingsFlowWithLookupMethod Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> method = default;
            Option<string?> csrfToken = default;
            Option<bool?> lookupSecretConfirm = default;
            Option<bool?> lookupSecretDisable = default;
            Option<bool?> lookupSecretRegenerate = default;
            Option<bool?> lookupSecretReveal = default;
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
                        case "csrf_token":
                            csrfToken = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "lookup_secret_confirm":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                lookupSecretConfirm = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "lookup_secret_disable":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                lookupSecretDisable = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "lookup_secret_regenerate":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                lookupSecretRegenerate = new Option<bool?>(utf8JsonReader.GetBoolean());
                            break;
                        case "lookup_secret_reveal":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                lookupSecretReveal = new Option<bool?>(utf8JsonReader.GetBoolean());
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
                throw new ArgumentException("Property is required for class KratosUpdateSettingsFlowWithLookupMethod.", nameof(method));

            if (method.IsSet && method.Value == null)
                throw new ArgumentNullException(nameof(method), "Property is not nullable for class KratosUpdateSettingsFlowWithLookupMethod.");

            if (csrfToken.IsSet && csrfToken.Value == null)
                throw new ArgumentNullException(nameof(csrfToken), "Property is not nullable for class KratosUpdateSettingsFlowWithLookupMethod.");

            if (lookupSecretConfirm.IsSet && lookupSecretConfirm.Value == null)
                throw new ArgumentNullException(nameof(lookupSecretConfirm), "Property is not nullable for class KratosUpdateSettingsFlowWithLookupMethod.");

            if (lookupSecretDisable.IsSet && lookupSecretDisable.Value == null)
                throw new ArgumentNullException(nameof(lookupSecretDisable), "Property is not nullable for class KratosUpdateSettingsFlowWithLookupMethod.");

            if (lookupSecretRegenerate.IsSet && lookupSecretRegenerate.Value == null)
                throw new ArgumentNullException(nameof(lookupSecretRegenerate), "Property is not nullable for class KratosUpdateSettingsFlowWithLookupMethod.");

            if (lookupSecretReveal.IsSet && lookupSecretReveal.Value == null)
                throw new ArgumentNullException(nameof(lookupSecretReveal), "Property is not nullable for class KratosUpdateSettingsFlowWithLookupMethod.");

            if (transientPayload.IsSet && transientPayload.Value == null)
                throw new ArgumentNullException(nameof(transientPayload), "Property is not nullable for class KratosUpdateSettingsFlowWithLookupMethod.");

            return new KratosUpdateSettingsFlowWithLookupMethod(method.Value!, csrfToken, lookupSecretConfirm, lookupSecretDisable, lookupSecretRegenerate, lookupSecretReveal, transientPayload);
        }

        /// <summary>
        /// Serializes a <see cref="KratosUpdateSettingsFlowWithLookupMethod" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosUpdateSettingsFlowWithLookupMethod"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, KratosUpdateSettingsFlowWithLookupMethod kratosUpdateSettingsFlowWithLookupMethod, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, kratosUpdateSettingsFlowWithLookupMethod, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="KratosUpdateSettingsFlowWithLookupMethod" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosUpdateSettingsFlowWithLookupMethod"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, KratosUpdateSettingsFlowWithLookupMethod kratosUpdateSettingsFlowWithLookupMethod, JsonSerializerOptions jsonSerializerOptions)
        {
            if (kratosUpdateSettingsFlowWithLookupMethod.Method == null)
                throw new ArgumentNullException(nameof(kratosUpdateSettingsFlowWithLookupMethod.Method), "Property is required for class KratosUpdateSettingsFlowWithLookupMethod.");

            if (kratosUpdateSettingsFlowWithLookupMethod.CsrfTokenOption.IsSet && kratosUpdateSettingsFlowWithLookupMethod.CsrfToken == null)
                throw new ArgumentNullException(nameof(kratosUpdateSettingsFlowWithLookupMethod.CsrfToken), "Property is required for class KratosUpdateSettingsFlowWithLookupMethod.");

            if (kratosUpdateSettingsFlowWithLookupMethod.TransientPayloadOption.IsSet && kratosUpdateSettingsFlowWithLookupMethod.TransientPayload == null)
                throw new ArgumentNullException(nameof(kratosUpdateSettingsFlowWithLookupMethod.TransientPayload), "Property is required for class KratosUpdateSettingsFlowWithLookupMethod.");

            writer.WriteString("method", kratosUpdateSettingsFlowWithLookupMethod.Method);

            if (kratosUpdateSettingsFlowWithLookupMethod.CsrfTokenOption.IsSet)
                writer.WriteString("csrf_token", kratosUpdateSettingsFlowWithLookupMethod.CsrfToken);

            if (kratosUpdateSettingsFlowWithLookupMethod.LookupSecretConfirmOption.IsSet)
                writer.WriteBoolean("lookup_secret_confirm", kratosUpdateSettingsFlowWithLookupMethod.LookupSecretConfirmOption.Value!.Value);

            if (kratosUpdateSettingsFlowWithLookupMethod.LookupSecretDisableOption.IsSet)
                writer.WriteBoolean("lookup_secret_disable", kratosUpdateSettingsFlowWithLookupMethod.LookupSecretDisableOption.Value!.Value);

            if (kratosUpdateSettingsFlowWithLookupMethod.LookupSecretRegenerateOption.IsSet)
                writer.WriteBoolean("lookup_secret_regenerate", kratosUpdateSettingsFlowWithLookupMethod.LookupSecretRegenerateOption.Value!.Value);

            if (kratosUpdateSettingsFlowWithLookupMethod.LookupSecretRevealOption.IsSet)
                writer.WriteBoolean("lookup_secret_reveal", kratosUpdateSettingsFlowWithLookupMethod.LookupSecretRevealOption.Value!.Value);

            if (kratosUpdateSettingsFlowWithLookupMethod.TransientPayloadOption.IsSet)
            {
                writer.WritePropertyName("transient_payload");
                JsonSerializer.Serialize(writer, kratosUpdateSettingsFlowWithLookupMethod.TransientPayload, jsonSerializerOptions);
            }
        }
    }
}
