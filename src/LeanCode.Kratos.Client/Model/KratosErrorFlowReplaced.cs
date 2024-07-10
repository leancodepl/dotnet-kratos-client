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
    /// Is sent when a flow is replaced by a different flow of the same class
    /// </summary>
    public partial class KratosErrorFlowReplaced
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosErrorFlowReplaced" /> class.
        /// </summary>
        /// <param name="error">error</param>
        /// <param name="useFlowId">The flow ID that should be used for the new flow as it contains the correct messages.</param>
        [JsonConstructor]
        public KratosErrorFlowReplaced(Option<KratosGenericError?> error = default, Option<string?> useFlowId = default)
        {
            ErrorOption = error;
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
            sb.Append("class KratosErrorFlowReplaced {\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  UseFlowId: ").Append(UseFlowId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="KratosErrorFlowReplaced" />
    /// </summary>
    public class KratosErrorFlowReplacedJsonConverter : JsonConverter<KratosErrorFlowReplaced>
    {
        /// <summary>
        /// Deserializes json to <see cref="KratosErrorFlowReplaced" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override KratosErrorFlowReplaced Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<KratosGenericError?> error = default;
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
                        case "use_flow_id":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                useFlowId = new Option<string?>(utf8JsonReader.GetGuid());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (error.IsSet && error.Value == null)
                throw new ArgumentNullException(nameof(error), "Property is not nullable for class KratosErrorFlowReplaced.");

            if (useFlowId.IsSet && useFlowId.Value == null)
                throw new ArgumentNullException(nameof(useFlowId), "Property is not nullable for class KratosErrorFlowReplaced.");

            return new KratosErrorFlowReplaced(error, useFlowId);
        }

        /// <summary>
        /// Serializes a <see cref="KratosErrorFlowReplaced" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosErrorFlowReplaced"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, KratosErrorFlowReplaced kratosErrorFlowReplaced, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, kratosErrorFlowReplaced, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="KratosErrorFlowReplaced" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosErrorFlowReplaced"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, KratosErrorFlowReplaced kratosErrorFlowReplaced, JsonSerializerOptions jsonSerializerOptions)
        {
            if (kratosErrorFlowReplaced.ErrorOption.IsSet && kratosErrorFlowReplaced.Error == null)
                throw new ArgumentNullException(nameof(kratosErrorFlowReplaced.Error), "Property is required for class KratosErrorFlowReplaced.");

            if (kratosErrorFlowReplaced.UseFlowIdOption.IsSet && kratosErrorFlowReplaced.UseFlowId == null)
                throw new ArgumentNullException(nameof(kratosErrorFlowReplaced.UseFlowId), "Property is required for class KratosErrorFlowReplaced.");

            if (kratosErrorFlowReplaced.ErrorOption.IsSet)
            {
                writer.WritePropertyName("error");
                JsonSerializer.Serialize(writer, kratosErrorFlowReplaced.Error, jsonSerializerOptions);
            }
            if (kratosErrorFlowReplaced.UseFlowIdOption.IsSet)
                writer.WriteString("use_flow_id", kratosErrorFlowReplaced.UseFlowIdOption.Value);
        }
    }
}
