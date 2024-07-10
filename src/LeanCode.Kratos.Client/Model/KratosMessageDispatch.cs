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
    /// MessageDispatch represents an attempt of sending a courier message It contains the status of the attempt (failed or successful) and the error if any occured
    /// </summary>
    public partial class KratosMessageDispatch
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosMessageDispatch" /> class.
        /// </summary>
        /// <param name="createdAt">CreatedAt is a helper struct field for gobuffalo.pop.</param>
        /// <param name="id">The ID of this message dispatch</param>
        /// <param name="messageId">The ID of the message being dispatched</param>
        /// <param name="status">The status of this dispatch Either \&quot;failed\&quot; or \&quot;success\&quot; failed CourierMessageDispatchStatusFailed success CourierMessageDispatchStatusSuccess</param>
        /// <param name="updatedAt">UpdatedAt is a helper struct field for gobuffalo.pop.</param>
        /// <param name="error">error</param>
        [JsonConstructor]
        public KratosMessageDispatch(DateTime createdAt, string id, string messageId, StatusEnum status, DateTime updatedAt, Option<Object?> error = default)
        {
            CreatedAt = createdAt;
            Id = id;
            MessageId = messageId;
            Status = status;
            UpdatedAt = updatedAt;
            ErrorOption = error;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// The status of this dispatch Either \&quot;failed\&quot; or \&quot;success\&quot; failed CourierMessageDispatchStatusFailed success CourierMessageDispatchStatusSuccess
        /// </summary>
        /// <value>The status of this dispatch Either \&quot;failed\&quot; or \&quot;success\&quot; failed CourierMessageDispatchStatusFailed success CourierMessageDispatchStatusSuccess</value>
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Failed for value: failed
            /// </summary>
            Failed,

            /// <summary>
            /// Enum Success for value: success
            /// </summary>
            Success
        }

        /// <summary>
        /// Returns a <see cref="StatusEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static StatusEnum StatusEnumFromString(string value)
        {
            if (value.Equals("failed"))
                return StatusEnum.Failed;

            if (value.Equals("success"))
                return StatusEnum.Success;

            throw new NotImplementedException($"Could not convert value to type StatusEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="StatusEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static StatusEnum? StatusEnumFromStringOrDefault(string value)
        {
            if (value.Equals("failed"))
                return StatusEnum.Failed;

            if (value.Equals("success"))
                return StatusEnum.Success;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="StatusEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string StatusEnumToJsonValue(StatusEnum value)
        {
            if (value == StatusEnum.Failed)
                return "failed";

            if (value == StatusEnum.Success)
                return "success";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// The status of this dispatch Either \&quot;failed\&quot; or \&quot;success\&quot; failed CourierMessageDispatchStatusFailed success CourierMessageDispatchStatusSuccess
        /// </summary>
        /// <value>The status of this dispatch Either \&quot;failed\&quot; or \&quot;success\&quot; failed CourierMessageDispatchStatusFailed success CourierMessageDispatchStatusSuccess</value>
        [JsonPropertyName("status")]
        public StatusEnum Status { get; set; }

        /// <summary>
        /// CreatedAt is a helper struct field for gobuffalo.pop.
        /// </summary>
        /// <value>CreatedAt is a helper struct field for gobuffalo.pop.</value>
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// The ID of this message dispatch
        /// </summary>
        /// <value>The ID of this message dispatch</value>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The ID of the message being dispatched
        /// </summary>
        /// <value>The ID of the message being dispatched</value>
        [JsonPropertyName("message_id")]
        public string MessageId { get; set; }

        /// <summary>
        /// UpdatedAt is a helper struct field for gobuffalo.pop.
        /// </summary>
        /// <value>UpdatedAt is a helper struct field for gobuffalo.pop.</value>
        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Used to track the state of Error
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Object?> ErrorOption { get; private set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [JsonPropertyName("error")]
        public Object? Error { get { return this.ErrorOption; } set { this.ErrorOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class KratosMessageDispatch {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="KratosMessageDispatch" />
    /// </summary>
    public class KratosMessageDispatchJsonConverter : JsonConverter<KratosMessageDispatch>
    {
        /// <summary>
        /// The format to use to serialize CreatedAt
        /// </summary>
        public static string CreatedAtFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// The format to use to serialize UpdatedAt
        /// </summary>
        public static string UpdatedAtFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// Deserializes json to <see cref="KratosMessageDispatch" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override KratosMessageDispatch Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<DateTime?> createdAt = default;
            Option<string?> id = default;
            Option<string?> messageId = default;
            Option<KratosMessageDispatch.StatusEnum?> status = default;
            Option<DateTime?> updatedAt = default;
            Option<Object?> error = default;

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
                        case "created_at":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                createdAt = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "id":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                id = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "message_id":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                messageId = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        case "status":
                            string? statusRawValue = utf8JsonReader.GetString();
                            if (statusRawValue != null)
                                status = new Option<KratosMessageDispatch.StatusEnum?>(KratosMessageDispatch.StatusEnumFromStringOrDefault(statusRawValue));
                            break;
                        case "updated_at":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                updatedAt = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "error":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                error = new Option<Object?>(JsonSerializer.Deserialize<Object>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!createdAt.IsSet)
                throw new ArgumentException("Property is required for class KratosMessageDispatch.", nameof(createdAt));

            if (!id.IsSet)
                throw new ArgumentException("Property is required for class KratosMessageDispatch.", nameof(id));

            if (!messageId.IsSet)
                throw new ArgumentException("Property is required for class KratosMessageDispatch.", nameof(messageId));

            if (!status.IsSet)
                throw new ArgumentException("Property is required for class KratosMessageDispatch.", nameof(status));

            if (!updatedAt.IsSet)
                throw new ArgumentException("Property is required for class KratosMessageDispatch.", nameof(updatedAt));

            if (createdAt.IsSet && createdAt.Value == null)
                throw new ArgumentNullException(nameof(createdAt), "Property is not nullable for class KratosMessageDispatch.");

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class KratosMessageDispatch.");

            if (messageId.IsSet && messageId.Value == null)
                throw new ArgumentNullException(nameof(messageId), "Property is not nullable for class KratosMessageDispatch.");

            if (status.IsSet && status.Value == null)
                throw new ArgumentNullException(nameof(status), "Property is not nullable for class KratosMessageDispatch.");

            if (updatedAt.IsSet && updatedAt.Value == null)
                throw new ArgumentNullException(nameof(updatedAt), "Property is not nullable for class KratosMessageDispatch.");

            if (error.IsSet && error.Value == null)
                throw new ArgumentNullException(nameof(error), "Property is not nullable for class KratosMessageDispatch.");

            return new KratosMessageDispatch(createdAt.Value!.Value!, id.Value!, messageId.Value!, status.Value!.Value!, updatedAt.Value!.Value!, error);
        }

        /// <summary>
        /// Serializes a <see cref="KratosMessageDispatch" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosMessageDispatch"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, KratosMessageDispatch kratosMessageDispatch, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, kratosMessageDispatch, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="KratosMessageDispatch" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosMessageDispatch"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, KratosMessageDispatch kratosMessageDispatch, JsonSerializerOptions jsonSerializerOptions)
        {
            if (kratosMessageDispatch.Id == null)
                throw new ArgumentNullException(nameof(kratosMessageDispatch.Id), "Property is required for class KratosMessageDispatch.");

            if (kratosMessageDispatch.MessageId == null)
                throw new ArgumentNullException(nameof(kratosMessageDispatch.MessageId), "Property is required for class KratosMessageDispatch.");

            if (kratosMessageDispatch.ErrorOption.IsSet && kratosMessageDispatch.Error == null)
                throw new ArgumentNullException(nameof(kratosMessageDispatch.Error), "Property is required for class KratosMessageDispatch.");

            writer.WriteString("created_at", kratosMessageDispatch.CreatedAt.ToString(CreatedAtFormat));

            writer.WriteString("id", kratosMessageDispatch.Id);

            writer.WriteString("message_id", kratosMessageDispatch.MessageId);

            var statusRawValue = KratosMessageDispatch.StatusEnumToJsonValue(kratosMessageDispatch.Status);
            writer.WriteString("status", statusRawValue);
            writer.WriteString("updated_at", kratosMessageDispatch.UpdatedAt.ToString(UpdatedAtFormat));

            if (kratosMessageDispatch.ErrorOption.IsSet)
            {
                writer.WritePropertyName("error");
                JsonSerializer.Serialize(writer, kratosMessageDispatch.Error, jsonSerializerOptions);
            }
        }
    }
}
