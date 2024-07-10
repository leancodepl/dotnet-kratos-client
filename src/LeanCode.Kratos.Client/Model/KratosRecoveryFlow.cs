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
    /// This request is used when an identity wants to recover their account.  We recommend reading the [Account Recovery Documentation](../self-service/flows/password-reset-account-recovery)
    /// </summary>
    public partial class KratosRecoveryFlow
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosRecoveryFlow" /> class.
        /// </summary>
        /// <param name="expiresAt">ExpiresAt is the time (UTC) when the request expires. If the user still wishes to update the setting, a new request has to be initiated.</param>
        /// <param name="id">ID represents the request&#39;s unique ID. When performing the recovery flow, this represents the id in the recovery ui&#39;s query parameter: http://&lt;selfservice.flows.recovery.ui_url&gt;?request&#x3D;&lt;id&gt;</param>
        /// <param name="issuedAt">IssuedAt is the time (UTC) when the request occurred.</param>
        /// <param name="requestUrl">RequestURL is the initial URL that was requested from Ory Kratos. It can be used to forward information contained in the URL&#39;s path or query for example.</param>
        /// <param name="type">The flow type can either be &#x60;api&#x60; or &#x60;browser&#x60;.</param>
        /// <param name="ui">ui</param>
        /// <param name="active">Active, if set, contains the recovery method that is being used. It is initially not set.</param>
        /// <param name="continueWith">Contains possible actions that could follow this flow</param>
        /// <param name="returnTo">ReturnTo contains the requested return_to URL.</param>
        /// <param name="state">State represents the state of this request:  choose_method: ask the user to choose a method (e.g. recover account via email) sent_email: the email has been sent to the user passed_challenge: the request was successful and the recovery challenge was passed.</param>
        /// <param name="transientPayload">TransientPayload is used to pass data from the recovery flow to hooks and email templates</param>
        [JsonConstructor]
        public KratosRecoveryFlow(DateTime expiresAt, string id, DateTime issuedAt, string requestUrl, string type, KratosUiContainer ui, Option<string?> active = default, Option<List<KratosContinueWith>?> continueWith = default, Option<string?> returnTo = default, Object? state = default, Option<Object?> transientPayload = default)
        {
            ExpiresAt = expiresAt;
            Id = id;
            IssuedAt = issuedAt;
            RequestUrl = requestUrl;
            Type = type;
            Ui = ui;
            ActiveOption = active;
            ContinueWithOption = continueWith;
            ReturnToOption = returnTo;
            State = state;
            TransientPayloadOption = transientPayload;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// ExpiresAt is the time (UTC) when the request expires. If the user still wishes to update the setting, a new request has to be initiated.
        /// </summary>
        /// <value>ExpiresAt is the time (UTC) when the request expires. If the user still wishes to update the setting, a new request has to be initiated.</value>
        [JsonPropertyName("expires_at")]
        public DateTime ExpiresAt { get; set; }

        /// <summary>
        /// ID represents the request&#39;s unique ID. When performing the recovery flow, this represents the id in the recovery ui&#39;s query parameter: http://&lt;selfservice.flows.recovery.ui_url&gt;?request&#x3D;&lt;id&gt;
        /// </summary>
        /// <value>ID represents the request&#39;s unique ID. When performing the recovery flow, this represents the id in the recovery ui&#39;s query parameter: http://&lt;selfservice.flows.recovery.ui_url&gt;?request&#x3D;&lt;id&gt;</value>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// IssuedAt is the time (UTC) when the request occurred.
        /// </summary>
        /// <value>IssuedAt is the time (UTC) when the request occurred.</value>
        [JsonPropertyName("issued_at")]
        public DateTime IssuedAt { get; set; }

        /// <summary>
        /// RequestURL is the initial URL that was requested from Ory Kratos. It can be used to forward information contained in the URL&#39;s path or query for example.
        /// </summary>
        /// <value>RequestURL is the initial URL that was requested from Ory Kratos. It can be used to forward information contained in the URL&#39;s path or query for example.</value>
        [JsonPropertyName("request_url")]
        public string RequestUrl { get; set; }

        /// <summary>
        /// The flow type can either be &#x60;api&#x60; or &#x60;browser&#x60;.
        /// </summary>
        /// <value>The flow type can either be &#x60;api&#x60; or &#x60;browser&#x60;.</value>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Ui
        /// </summary>
        [JsonPropertyName("ui")]
        public KratosUiContainer Ui { get; set; }

        /// <summary>
        /// Used to track the state of Active
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> ActiveOption { get; private set; }

        /// <summary>
        /// Active, if set, contains the recovery method that is being used. It is initially not set.
        /// </summary>
        /// <value>Active, if set, contains the recovery method that is being used. It is initially not set.</value>
        [JsonPropertyName("active")]
        public string? Active { get { return this.ActiveOption; } set { this.ActiveOption = new(value); } }

        /// <summary>
        /// Used to track the state of ContinueWith
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<KratosContinueWith>?> ContinueWithOption { get; private set; }

        /// <summary>
        /// Contains possible actions that could follow this flow
        /// </summary>
        /// <value>Contains possible actions that could follow this flow</value>
        [JsonPropertyName("continue_with")]
        public List<KratosContinueWith>? ContinueWith { get { return this.ContinueWithOption; } set { this.ContinueWithOption = new(value); } }

        /// <summary>
        /// Used to track the state of ReturnTo
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> ReturnToOption { get; private set; }

        /// <summary>
        /// ReturnTo contains the requested return_to URL.
        /// </summary>
        /// <value>ReturnTo contains the requested return_to URL.</value>
        [JsonPropertyName("return_to")]
        public string? ReturnTo { get { return this.ReturnToOption; } set { this.ReturnToOption = new(value); } }

        /// <summary>
        /// State represents the state of this request:  choose_method: ask the user to choose a method (e.g. recover account via email) sent_email: the email has been sent to the user passed_challenge: the request was successful and the recovery challenge was passed.
        /// </summary>
        /// <value>State represents the state of this request:  choose_method: ask the user to choose a method (e.g. recover account via email) sent_email: the email has been sent to the user passed_challenge: the request was successful and the recovery challenge was passed.</value>
        [JsonPropertyName("state")]
        public Object? State { get; set; }

        /// <summary>
        /// Used to track the state of TransientPayload
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Object?> TransientPayloadOption { get; private set; }

        /// <summary>
        /// TransientPayload is used to pass data from the recovery flow to hooks and email templates
        /// </summary>
        /// <value>TransientPayload is used to pass data from the recovery flow to hooks and email templates</value>
        [JsonPropertyName("transient_payload")]
        public Object? TransientPayload { get { return this.TransientPayloadOption; } set { this.TransientPayloadOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class KratosRecoveryFlow {\n");
            sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IssuedAt: ").Append(IssuedAt).Append("\n");
            sb.Append("  RequestUrl: ").Append(RequestUrl).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Ui: ").Append(Ui).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  ContinueWith: ").Append(ContinueWith).Append("\n");
            sb.Append("  ReturnTo: ").Append(ReturnTo).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  TransientPayload: ").Append(TransientPayload).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="KratosRecoveryFlow" />
    /// </summary>
    public class KratosRecoveryFlowJsonConverter : JsonConverter<KratosRecoveryFlow>
    {
        /// <summary>
        /// The format to use to serialize ExpiresAt
        /// </summary>
        public static string ExpiresAtFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// The format to use to serialize IssuedAt
        /// </summary>
        public static string IssuedAtFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// Deserializes json to <see cref="KratosRecoveryFlow" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override KratosRecoveryFlow Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<DateTime?> expiresAt = default;
            Option<string?> id = default;
            Option<DateTime?> issuedAt = default;
            Option<string?> requestUrl = default;
            Option<string?> type = default;
            Option<KratosUiContainer?> ui = default;
            Option<string?> active = default;
            Option<List<KratosContinueWith>?> continueWith = default;
            Option<string?> returnTo = default;
            Option<Object?> state = default;
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
                        case "expires_at":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                expiresAt = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "id":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                id = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "issued_at":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                issuedAt = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "request_url":
                            requestUrl = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "type":
                            type = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "ui":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                ui = new Option<KratosUiContainer?>(JsonSerializer.Deserialize<KratosUiContainer>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "active":
                            active = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "continue_with":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                continueWith = new Option<List<KratosContinueWith>?>(JsonSerializer.Deserialize<List<KratosContinueWith>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "return_to":
                            returnTo = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "state":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                state = new Option<Object?>(JsonSerializer.Deserialize<Object>(ref utf8JsonReader, jsonSerializerOptions));
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

            if (!expiresAt.IsSet)
                throw new ArgumentException("Property is required for class KratosRecoveryFlow.", nameof(expiresAt));

            if (!id.IsSet)
                throw new ArgumentException("Property is required for class KratosRecoveryFlow.", nameof(id));

            if (!issuedAt.IsSet)
                throw new ArgumentException("Property is required for class KratosRecoveryFlow.", nameof(issuedAt));

            if (!requestUrl.IsSet)
                throw new ArgumentException("Property is required for class KratosRecoveryFlow.", nameof(requestUrl));

            if (!type.IsSet)
                throw new ArgumentException("Property is required for class KratosRecoveryFlow.", nameof(type));

            if (!ui.IsSet)
                throw new ArgumentException("Property is required for class KratosRecoveryFlow.", nameof(ui));

            if (!state.IsSet)
                throw new ArgumentException("Property is required for class KratosRecoveryFlow.", nameof(state));

            if (expiresAt.IsSet && expiresAt.Value == null)
                throw new ArgumentNullException(nameof(expiresAt), "Property is not nullable for class KratosRecoveryFlow.");

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class KratosRecoveryFlow.");

            if (issuedAt.IsSet && issuedAt.Value == null)
                throw new ArgumentNullException(nameof(issuedAt), "Property is not nullable for class KratosRecoveryFlow.");

            if (requestUrl.IsSet && requestUrl.Value == null)
                throw new ArgumentNullException(nameof(requestUrl), "Property is not nullable for class KratosRecoveryFlow.");

            if (type.IsSet && type.Value == null)
                throw new ArgumentNullException(nameof(type), "Property is not nullable for class KratosRecoveryFlow.");

            if (ui.IsSet && ui.Value == null)
                throw new ArgumentNullException(nameof(ui), "Property is not nullable for class KratosRecoveryFlow.");

            if (active.IsSet && active.Value == null)
                throw new ArgumentNullException(nameof(active), "Property is not nullable for class KratosRecoveryFlow.");

            if (continueWith.IsSet && continueWith.Value == null)
                throw new ArgumentNullException(nameof(continueWith), "Property is not nullable for class KratosRecoveryFlow.");

            if (returnTo.IsSet && returnTo.Value == null)
                throw new ArgumentNullException(nameof(returnTo), "Property is not nullable for class KratosRecoveryFlow.");

            if (transientPayload.IsSet && transientPayload.Value == null)
                throw new ArgumentNullException(nameof(transientPayload), "Property is not nullable for class KratosRecoveryFlow.");

            return new KratosRecoveryFlow(expiresAt.Value!.Value!, id.Value!, issuedAt.Value!.Value!, requestUrl.Value!, type.Value!, ui.Value!, active, continueWith, returnTo, state.Value!, transientPayload);
        }

        /// <summary>
        /// Serializes a <see cref="KratosRecoveryFlow" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosRecoveryFlow"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, KratosRecoveryFlow kratosRecoveryFlow, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, kratosRecoveryFlow, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="KratosRecoveryFlow" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosRecoveryFlow"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, KratosRecoveryFlow kratosRecoveryFlow, JsonSerializerOptions jsonSerializerOptions)
        {
            if (kratosRecoveryFlow.Id == null)
                throw new ArgumentNullException(nameof(kratosRecoveryFlow.Id), "Property is required for class KratosRecoveryFlow.");

            if (kratosRecoveryFlow.RequestUrl == null)
                throw new ArgumentNullException(nameof(kratosRecoveryFlow.RequestUrl), "Property is required for class KratosRecoveryFlow.");

            if (kratosRecoveryFlow.Type == null)
                throw new ArgumentNullException(nameof(kratosRecoveryFlow.Type), "Property is required for class KratosRecoveryFlow.");

            if (kratosRecoveryFlow.Ui == null)
                throw new ArgumentNullException(nameof(kratosRecoveryFlow.Ui), "Property is required for class KratosRecoveryFlow.");

            if (kratosRecoveryFlow.ActiveOption.IsSet && kratosRecoveryFlow.Active == null)
                throw new ArgumentNullException(nameof(kratosRecoveryFlow.Active), "Property is required for class KratosRecoveryFlow.");

            if (kratosRecoveryFlow.ContinueWithOption.IsSet && kratosRecoveryFlow.ContinueWith == null)
                throw new ArgumentNullException(nameof(kratosRecoveryFlow.ContinueWith), "Property is required for class KratosRecoveryFlow.");

            if (kratosRecoveryFlow.ReturnToOption.IsSet && kratosRecoveryFlow.ReturnTo == null)
                throw new ArgumentNullException(nameof(kratosRecoveryFlow.ReturnTo), "Property is required for class KratosRecoveryFlow.");

            if (kratosRecoveryFlow.TransientPayloadOption.IsSet && kratosRecoveryFlow.TransientPayload == null)
                throw new ArgumentNullException(nameof(kratosRecoveryFlow.TransientPayload), "Property is required for class KratosRecoveryFlow.");

            writer.WriteString("expires_at", kratosRecoveryFlow.ExpiresAt.ToString(ExpiresAtFormat));

            writer.WriteString("id", kratosRecoveryFlow.Id);

            writer.WriteString("issued_at", kratosRecoveryFlow.IssuedAt.ToString(IssuedAtFormat));

            writer.WriteString("request_url", kratosRecoveryFlow.RequestUrl);

            writer.WriteString("type", kratosRecoveryFlow.Type);

            writer.WritePropertyName("ui");
            JsonSerializer.Serialize(writer, kratosRecoveryFlow.Ui, jsonSerializerOptions);
            if (kratosRecoveryFlow.ActiveOption.IsSet)
                writer.WriteString("active", kratosRecoveryFlow.Active);

            if (kratosRecoveryFlow.ContinueWithOption.IsSet)
            {
                writer.WritePropertyName("continue_with");
                JsonSerializer.Serialize(writer, kratosRecoveryFlow.ContinueWith, jsonSerializerOptions);
            }
            if (kratosRecoveryFlow.ReturnToOption.IsSet)
                writer.WriteString("return_to", kratosRecoveryFlow.ReturnTo);

            if (kratosRecoveryFlow.State != null)
            {
                writer.WritePropertyName("state");
                JsonSerializer.Serialize(writer, kratosRecoveryFlow.State, jsonSerializerOptions);
            }
            else
                writer.WriteNull("state");
            if (kratosRecoveryFlow.TransientPayloadOption.IsSet)
            {
                writer.WritePropertyName("transient_payload");
                JsonSerializer.Serialize(writer, kratosRecoveryFlow.TransientPayload, jsonSerializerOptions);
            }
        }
    }
}
