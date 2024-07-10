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
    /// The Response for Registration Flows via API
    /// </summary>
    public partial class KratosSuccessfulNativeRegistration
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosSuccessfulNativeRegistration" /> class.
        /// </summary>
        /// <param name="identity">identity</param>
        /// <param name="continueWith">Contains a list of actions, that could follow this flow  It can, for example, this will contain a reference to the verification flow, created as part of the user&#39;s registration or the token of the session.</param>
        /// <param name="session">session</param>
        /// <param name="sessionToken">The Session Token  This field is only set when the session hook is configured as a post-registration hook.  A session token is equivalent to a session cookie, but it can be sent in the HTTP Authorization Header:  Authorization: bearer ${session-token}  The session token is only issued for API flows, not for Browser flows!</param>
        [JsonConstructor]
        public KratosSuccessfulNativeRegistration(KratosIdentity identity, Option<List<KratosContinueWith>?> continueWith = default, Option<KratosSession?> session = default, Option<string?> sessionToken = default)
        {
            Identity = identity;
            ContinueWithOption = continueWith;
            SessionOption = session;
            SessionTokenOption = sessionToken;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Identity
        /// </summary>
        [JsonPropertyName("identity")]
        public KratosIdentity Identity { get; set; }

        /// <summary>
        /// Used to track the state of ContinueWith
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<KratosContinueWith>?> ContinueWithOption { get; private set; }

        /// <summary>
        /// Contains a list of actions, that could follow this flow  It can, for example, this will contain a reference to the verification flow, created as part of the user&#39;s registration or the token of the session.
        /// </summary>
        /// <value>Contains a list of actions, that could follow this flow  It can, for example, this will contain a reference to the verification flow, created as part of the user&#39;s registration or the token of the session.</value>
        [JsonPropertyName("continue_with")]
        public List<KratosContinueWith>? ContinueWith { get { return this.ContinueWithOption; } set { this.ContinueWithOption = new(value); } }

        /// <summary>
        /// Used to track the state of Session
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<KratosSession?> SessionOption { get; private set; }

        /// <summary>
        /// Gets or Sets Session
        /// </summary>
        [JsonPropertyName("session")]
        public KratosSession? Session { get { return this.SessionOption; } set { this.SessionOption = new(value); } }

        /// <summary>
        /// Used to track the state of SessionToken
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> SessionTokenOption { get; private set; }

        /// <summary>
        /// The Session Token  This field is only set when the session hook is configured as a post-registration hook.  A session token is equivalent to a session cookie, but it can be sent in the HTTP Authorization Header:  Authorization: bearer ${session-token}  The session token is only issued for API flows, not for Browser flows!
        /// </summary>
        /// <value>The Session Token  This field is only set when the session hook is configured as a post-registration hook.  A session token is equivalent to a session cookie, but it can be sent in the HTTP Authorization Header:  Authorization: bearer ${session-token}  The session token is only issued for API flows, not for Browser flows!</value>
        [JsonPropertyName("session_token")]
        public string? SessionToken { get { return this.SessionTokenOption; } set { this.SessionTokenOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class KratosSuccessfulNativeRegistration {\n");
            sb.Append("  Identity: ").Append(Identity).Append("\n");
            sb.Append("  ContinueWith: ").Append(ContinueWith).Append("\n");
            sb.Append("  Session: ").Append(Session).Append("\n");
            sb.Append("  SessionToken: ").Append(SessionToken).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="KratosSuccessfulNativeRegistration" />
    /// </summary>
    public class KratosSuccessfulNativeRegistrationJsonConverter : JsonConverter<KratosSuccessfulNativeRegistration>
    {
        /// <summary>
        /// Deserializes json to <see cref="KratosSuccessfulNativeRegistration" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override KratosSuccessfulNativeRegistration Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<KratosIdentity?> identity = default;
            Option<List<KratosContinueWith>?> continueWith = default;
            Option<KratosSession?> session = default;
            Option<string?> sessionToken = default;

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
                        case "identity":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                identity = new Option<KratosIdentity?>(JsonSerializer.Deserialize<KratosIdentity>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "continue_with":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                continueWith = new Option<List<KratosContinueWith>?>(JsonSerializer.Deserialize<List<KratosContinueWith>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "session":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                session = new Option<KratosSession?>(JsonSerializer.Deserialize<KratosSession>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "session_token":
                            sessionToken = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!identity.IsSet)
                throw new ArgumentException("Property is required for class KratosSuccessfulNativeRegistration.", nameof(identity));

            if (identity.IsSet && identity.Value == null)
                throw new ArgumentNullException(nameof(identity), "Property is not nullable for class KratosSuccessfulNativeRegistration.");

            if (continueWith.IsSet && continueWith.Value == null)
                throw new ArgumentNullException(nameof(continueWith), "Property is not nullable for class KratosSuccessfulNativeRegistration.");

            if (session.IsSet && session.Value == null)
                throw new ArgumentNullException(nameof(session), "Property is not nullable for class KratosSuccessfulNativeRegistration.");

            if (sessionToken.IsSet && sessionToken.Value == null)
                throw new ArgumentNullException(nameof(sessionToken), "Property is not nullable for class KratosSuccessfulNativeRegistration.");

            return new KratosSuccessfulNativeRegistration(identity.Value!, continueWith, session, sessionToken);
        }

        /// <summary>
        /// Serializes a <see cref="KratosSuccessfulNativeRegistration" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosSuccessfulNativeRegistration"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, KratosSuccessfulNativeRegistration kratosSuccessfulNativeRegistration, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, kratosSuccessfulNativeRegistration, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="KratosSuccessfulNativeRegistration" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosSuccessfulNativeRegistration"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, KratosSuccessfulNativeRegistration kratosSuccessfulNativeRegistration, JsonSerializerOptions jsonSerializerOptions)
        {
            if (kratosSuccessfulNativeRegistration.Identity == null)
                throw new ArgumentNullException(nameof(kratosSuccessfulNativeRegistration.Identity), "Property is required for class KratosSuccessfulNativeRegistration.");

            if (kratosSuccessfulNativeRegistration.ContinueWithOption.IsSet && kratosSuccessfulNativeRegistration.ContinueWith == null)
                throw new ArgumentNullException(nameof(kratosSuccessfulNativeRegistration.ContinueWith), "Property is required for class KratosSuccessfulNativeRegistration.");

            if (kratosSuccessfulNativeRegistration.SessionOption.IsSet && kratosSuccessfulNativeRegistration.Session == null)
                throw new ArgumentNullException(nameof(kratosSuccessfulNativeRegistration.Session), "Property is required for class KratosSuccessfulNativeRegistration.");

            if (kratosSuccessfulNativeRegistration.SessionTokenOption.IsSet && kratosSuccessfulNativeRegistration.SessionToken == null)
                throw new ArgumentNullException(nameof(kratosSuccessfulNativeRegistration.SessionToken), "Property is required for class KratosSuccessfulNativeRegistration.");

            writer.WritePropertyName("identity");
            JsonSerializer.Serialize(writer, kratosSuccessfulNativeRegistration.Identity, jsonSerializerOptions);
            if (kratosSuccessfulNativeRegistration.ContinueWithOption.IsSet)
            {
                writer.WritePropertyName("continue_with");
                JsonSerializer.Serialize(writer, kratosSuccessfulNativeRegistration.ContinueWith, jsonSerializerOptions);
            }
            if (kratosSuccessfulNativeRegistration.SessionOption.IsSet)
            {
                writer.WritePropertyName("session");
                JsonSerializer.Serialize(writer, kratosSuccessfulNativeRegistration.Session, jsonSerializerOptions);
            }
            if (kratosSuccessfulNativeRegistration.SessionTokenOption.IsSet)
                writer.WriteString("session_token", kratosSuccessfulNativeRegistration.SessionToken);
        }
    }
}