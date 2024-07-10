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
    /// Deleted Session Count
    /// </summary>
    public partial class KratosDeleteMySessionsCount
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosDeleteMySessionsCount" /> class.
        /// </summary>
        /// <param name="count">The number of sessions that were revoked.</param>
        [JsonConstructor]
        public KratosDeleteMySessionsCount(Option<long?> count = default)
        {
            CountOption = count;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Count
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<long?> CountOption { get; private set; }

        /// <summary>
        /// The number of sessions that were revoked.
        /// </summary>
        /// <value>The number of sessions that were revoked.</value>
        [JsonPropertyName("count")]
        public long? Count { get { return this.CountOption; } set { this.CountOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class KratosDeleteMySessionsCount {\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="KratosDeleteMySessionsCount" />
    /// </summary>
    public class KratosDeleteMySessionsCountJsonConverter : JsonConverter<KratosDeleteMySessionsCount>
    {
        /// <summary>
        /// Deserializes json to <see cref="KratosDeleteMySessionsCount" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override KratosDeleteMySessionsCount Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<long?> count = default;

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
                        case "count":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                count = new Option<long?>(utf8JsonReader.GetInt64());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (count.IsSet && count.Value == null)
                throw new ArgumentNullException(nameof(count), "Property is not nullable for class KratosDeleteMySessionsCount.");

            return new KratosDeleteMySessionsCount(count);
        }

        /// <summary>
        /// Serializes a <see cref="KratosDeleteMySessionsCount" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosDeleteMySessionsCount"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, KratosDeleteMySessionsCount kratosDeleteMySessionsCount, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, kratosDeleteMySessionsCount, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="KratosDeleteMySessionsCount" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosDeleteMySessionsCount"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, KratosDeleteMySessionsCount kratosDeleteMySessionsCount, JsonSerializerOptions jsonSerializerOptions)
        {
            if (kratosDeleteMySessionsCount.CountOption.IsSet)
                writer.WriteNumber("count", kratosDeleteMySessionsCount.CountOption.Value!.Value);
        }
    }
}