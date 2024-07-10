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
    public partial class KratosSuccessfulCodeExchangeResponse
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosSuccessfulCodeExchangeResponse" /> class.
        /// </summary>
        /// <param name="session">session</param>
        /// <param name="sessionToken">The Session Token  A session token is equivalent to a session cookie, but it can be sent in the HTTP Authorization Header:  Authorization: bearer ${session-token}  The session token is only issued for API flows, not for Browser flows!</param>
        [JsonConstructor]
        public KratosSuccessfulCodeExchangeResponse(KratosSession session, Option<string?> sessionToken = default)
        {
            Session = session;
            SessionTokenOption = sessionToken;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets Session
        /// </summary>
        [JsonPropertyName("session")]
        public KratosSession Session { get; set; }

        /// <summary>
        /// Used to track the state of SessionToken
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> SessionTokenOption { get; private set; }

        /// <summary>
        /// The Session Token  A session token is equivalent to a session cookie, but it can be sent in the HTTP Authorization Header:  Authorization: bearer ${session-token}  The session token is only issued for API flows, not for Browser flows!
        /// </summary>
        /// <value>The Session Token  A session token is equivalent to a session cookie, but it can be sent in the HTTP Authorization Header:  Authorization: bearer ${session-token}  The session token is only issued for API flows, not for Browser flows!</value>
        [JsonPropertyName("session_token")]
        public string? SessionToken { get { return this.SessionTokenOption; } set { this.SessionTokenOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class KratosSuccessfulCodeExchangeResponse {\n");
            sb.Append("  Session: ").Append(Session).Append("\n");
            sb.Append("  SessionToken: ").Append(SessionToken).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="KratosSuccessfulCodeExchangeResponse" />
    /// </summary>
    public class KratosSuccessfulCodeExchangeResponseJsonConverter : JsonConverter<KratosSuccessfulCodeExchangeResponse>
    {
        /// <summary>
        /// Deserializes json to <see cref="KratosSuccessfulCodeExchangeResponse" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override KratosSuccessfulCodeExchangeResponse Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

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

            if (!session.IsSet)
                throw new ArgumentException("Property is required for class KratosSuccessfulCodeExchangeResponse.", nameof(session));

            if (session.IsSet && session.Value == null)
                throw new ArgumentNullException(nameof(session), "Property is not nullable for class KratosSuccessfulCodeExchangeResponse.");

            if (sessionToken.IsSet && sessionToken.Value == null)
                throw new ArgumentNullException(nameof(sessionToken), "Property is not nullable for class KratosSuccessfulCodeExchangeResponse.");

            return new KratosSuccessfulCodeExchangeResponse(session.Value!, sessionToken);
        }

        /// <summary>
        /// Serializes a <see cref="KratosSuccessfulCodeExchangeResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosSuccessfulCodeExchangeResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, KratosSuccessfulCodeExchangeResponse kratosSuccessfulCodeExchangeResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, kratosSuccessfulCodeExchangeResponse, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="KratosSuccessfulCodeExchangeResponse" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosSuccessfulCodeExchangeResponse"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, KratosSuccessfulCodeExchangeResponse kratosSuccessfulCodeExchangeResponse, JsonSerializerOptions jsonSerializerOptions)
        {
            if (kratosSuccessfulCodeExchangeResponse.Session == null)
                throw new ArgumentNullException(nameof(kratosSuccessfulCodeExchangeResponse.Session), "Property is required for class KratosSuccessfulCodeExchangeResponse.");

            if (kratosSuccessfulCodeExchangeResponse.SessionTokenOption.IsSet && kratosSuccessfulCodeExchangeResponse.SessionToken == null)
                throw new ArgumentNullException(nameof(kratosSuccessfulCodeExchangeResponse.SessionToken), "Property is required for class KratosSuccessfulCodeExchangeResponse.");

            writer.WritePropertyName("session");
            JsonSerializer.Serialize(writer, kratosSuccessfulCodeExchangeResponse.Session, jsonSerializerOptions);
            if (kratosSuccessfulCodeExchangeResponse.SessionTokenOption.IsSet)
                writer.WriteString("session_token", kratosSuccessfulCodeExchangeResponse.SessionToken);
        }
    }
}
