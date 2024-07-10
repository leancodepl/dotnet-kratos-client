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
    /// Is sent when a flow is expired
    /// </summary>
    public partial class KratosSelfServiceFlowExpiredError
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosSelfServiceFlowExpiredError" /> class.
        /// </summary>
        /// <param name="error">error</param>
        /// <param name="expiredAt">When the flow has expired</param>
        /// <param name="since">A Duration represents the elapsed time between two instants as an int64 nanosecond count. The representation limits the largest representable duration to approximately 290 years.</param>
        /// <param name="useFlowId">The flow ID that should be used for the new flow as it contains the correct messages.</param>
        [JsonConstructor]
        public KratosSelfServiceFlowExpiredError(Option<KratosGenericError?> error = default, Option<DateTime?> expiredAt = default, Option<long?> since = default, Option<string?> useFlowId = default)
        {
            ErrorOption = error;
            ExpiredAtOption = expiredAt;
            SinceOption = since;
            UseFlowIdOption = useFlowId;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Error
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<KratosGenericError?> ErrorOption { get; private set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [JsonPropertyName("error")]
        public KratosGenericError? Error { get { return this.ErrorOption; } set { this.ErrorOption = new(value); } }

        /// <summary>
        /// Used to track the state of ExpiredAt
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<DateTime?> ExpiredAtOption { get; private set; }

        /// <summary>
        /// When the flow has expired
        /// </summary>
        /// <value>When the flow has expired</value>
        [JsonPropertyName("expired_at")]
        public DateTime? ExpiredAt { get { return this.ExpiredAtOption; } set { this.ExpiredAtOption = new(value); } }

        /// <summary>
        /// Used to track the state of Since
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<long?> SinceOption { get; private set; }

        /// <summary>
        /// A Duration represents the elapsed time between two instants as an int64 nanosecond count. The representation limits the largest representable duration to approximately 290 years.
        /// </summary>
        /// <value>A Duration represents the elapsed time between two instants as an int64 nanosecond count. The representation limits the largest representable duration to approximately 290 years.</value>
        [JsonPropertyName("since")]
        public long? Since { get { return this.SinceOption; } set { this.SinceOption = new(value); } }

        /// <summary>
        /// Used to track the state of UseFlowId
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> UseFlowIdOption { get; private set; }

        /// <summary>
        /// The flow ID that should be used for the new flow as it contains the correct messages.
        /// </summary>
        /// <value>The flow ID that should be used for the new flow as it contains the correct messages.</value>
        [JsonPropertyName("use_flow_id")]
        public string? UseFlowId { get { return this.UseFlowIdOption; } set { this.UseFlowIdOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class KratosSelfServiceFlowExpiredError {\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  ExpiredAt: ").Append(ExpiredAt).Append("\n");
            sb.Append("  Since: ").Append(Since).Append("\n");
            sb.Append("  UseFlowId: ").Append(UseFlowId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="KratosSelfServiceFlowExpiredError" />
    /// </summary>
    public class KratosSelfServiceFlowExpiredErrorJsonConverter : JsonConverter<KratosSelfServiceFlowExpiredError>
    {
        /// <summary>
        /// The format to use to serialize ExpiredAt
        /// </summary>
        public static string ExpiredAtFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// Deserializes json to <see cref="KratosSelfServiceFlowExpiredError" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override KratosSelfServiceFlowExpiredError Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<KratosGenericError?> error = default;
            Option<DateTime?> expiredAt = default;
            Option<long?> since = default;
            Option<string?> useFlowId = default;

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
                        case "error":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                error = new Option<KratosGenericError?>(JsonSerializer.Deserialize<KratosGenericError>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "expired_at":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                expiredAt = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "since":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                since = new Option<long?>(utf8JsonReader.GetInt64());
                            break;
                        case "use_flow_id":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                useFlowId = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (error.IsSet && error.Value == null)
                throw new ArgumentNullException(nameof(error), "Property is not nullable for class KratosSelfServiceFlowExpiredError.");

            if (expiredAt.IsSet && expiredAt.Value == null)
                throw new ArgumentNullException(nameof(expiredAt), "Property is not nullable for class KratosSelfServiceFlowExpiredError.");

            if (since.IsSet && since.Value == null)
                throw new ArgumentNullException(nameof(since), "Property is not nullable for class KratosSelfServiceFlowExpiredError.");

            if (useFlowId.IsSet && useFlowId.Value == null)
                throw new ArgumentNullException(nameof(useFlowId), "Property is not nullable for class KratosSelfServiceFlowExpiredError.");

            return new KratosSelfServiceFlowExpiredError(error, expiredAt, since, useFlowId);
        }

        /// <summary>
        /// Serializes a <see cref="KratosSelfServiceFlowExpiredError" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosSelfServiceFlowExpiredError"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, KratosSelfServiceFlowExpiredError kratosSelfServiceFlowExpiredError, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, kratosSelfServiceFlowExpiredError, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="KratosSelfServiceFlowExpiredError" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosSelfServiceFlowExpiredError"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, KratosSelfServiceFlowExpiredError kratosSelfServiceFlowExpiredError, JsonSerializerOptions jsonSerializerOptions)
        {
            if (kratosSelfServiceFlowExpiredError.ErrorOption.IsSet && kratosSelfServiceFlowExpiredError.Error == null)
                throw new ArgumentNullException(nameof(kratosSelfServiceFlowExpiredError.Error), "Property is required for class KratosSelfServiceFlowExpiredError.");

            if (kratosSelfServiceFlowExpiredError.UseFlowIdOption.IsSet && kratosSelfServiceFlowExpiredError.UseFlowId == null)
                throw new ArgumentNullException(nameof(kratosSelfServiceFlowExpiredError.UseFlowId), "Property is required for class KratosSelfServiceFlowExpiredError.");

            if (kratosSelfServiceFlowExpiredError.ErrorOption.IsSet)
            {
                writer.WritePropertyName("error");
                JsonSerializer.Serialize(writer, kratosSelfServiceFlowExpiredError.Error, jsonSerializerOptions);
            }
            if (kratosSelfServiceFlowExpiredError.ExpiredAtOption.IsSet)
                writer.WriteString("expired_at", kratosSelfServiceFlowExpiredError.ExpiredAtOption.Value!.Value.ToString(ExpiredAtFormat));

            if (kratosSelfServiceFlowExpiredError.SinceOption.IsSet)
                writer.WriteNumber("since", kratosSelfServiceFlowExpiredError.SinceOption.Value!.Value);

            if (kratosSelfServiceFlowExpiredError.UseFlowIdOption.IsSet)
                writer.WriteString("use_flow_id", kratosSelfServiceFlowExpiredError.UseFlowIdOption.Value);
        }
    }
}
