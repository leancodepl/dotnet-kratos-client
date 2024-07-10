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
    /// KratosHealthStatus
    /// </summary>
    public partial class KratosHealthStatus
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosHealthStatus" /> class.
        /// </summary>
        /// <param name="status">Status always contains \&quot;ok\&quot;.</param>
        [JsonConstructor]
        public KratosHealthStatus(Option<string?> status = default)
        {
            StatusOption = status;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Status
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> StatusOption { get; private set; }

        /// <summary>
        /// Status always contains \&quot;ok\&quot;.
        /// </summary>
        /// <value>Status always contains \&quot;ok\&quot;.</value>
        [JsonPropertyName("status")]
        public string? Status { get { return this.StatusOption; } set { this.StatusOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class KratosHealthStatus {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="KratosHealthStatus" />
    /// </summary>
    public class KratosHealthStatusJsonConverter : JsonConverter<KratosHealthStatus>
    {
        /// <summary>
        /// Deserializes json to <see cref="KratosHealthStatus" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override KratosHealthStatus Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> status = default;

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
                        case "status":
                            status = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (status.IsSet && status.Value == null)
                throw new ArgumentNullException(nameof(status), "Property is not nullable for class KratosHealthStatus.");

            return new KratosHealthStatus(status);
        }

        /// <summary>
        /// Serializes a <see cref="KratosHealthStatus" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosHealthStatus"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, KratosHealthStatus kratosHealthStatus, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, kratosHealthStatus, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="KratosHealthStatus" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosHealthStatus"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, KratosHealthStatus kratosHealthStatus, JsonSerializerOptions jsonSerializerOptions)
        {
            if (kratosHealthStatus.StatusOption.IsSet && kratosHealthStatus.Status == null)
                throw new ArgumentNullException(nameof(kratosHealthStatus.Status), "Property is required for class KratosHealthStatus.");

            if (kratosHealthStatus.StatusOption.IsSet)
                writer.WriteString("status", kratosHealthStatus.Status);
        }
    }
}