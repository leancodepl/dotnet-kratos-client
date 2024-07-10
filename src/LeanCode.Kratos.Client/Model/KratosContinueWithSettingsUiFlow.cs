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
    /// KratosContinueWithSettingsUiFlow
    /// </summary>
    public partial class KratosContinueWithSettingsUiFlow
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosContinueWithSettingsUiFlow" /> class.
        /// </summary>
        /// <param name="id">The ID of the settings flow</param>
        [JsonConstructor]
        public KratosContinueWithSettingsUiFlow(string id)
        {
            Id = id;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// The ID of the settings flow
        /// </summary>
        /// <value>The ID of the settings flow</value>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class KratosContinueWithSettingsUiFlow {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="KratosContinueWithSettingsUiFlow" />
    /// </summary>
    public class KratosContinueWithSettingsUiFlowJsonConverter : JsonConverter<KratosContinueWithSettingsUiFlow>
    {
        /// <summary>
        /// Deserializes json to <see cref="KratosContinueWithSettingsUiFlow" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override KratosContinueWithSettingsUiFlow Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> id = default;

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
                        case "id":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                id = new Option<string?>(utf8JsonReader.GetGuid());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!id.IsSet)
                throw new ArgumentException("Property is required for class KratosContinueWithSettingsUiFlow.", nameof(id));

            if (id.IsSet && id.Value == null)
                throw new ArgumentNullException(nameof(id), "Property is not nullable for class KratosContinueWithSettingsUiFlow.");

            return new KratosContinueWithSettingsUiFlow(id.Value!);
        }

        /// <summary>
        /// Serializes a <see cref="KratosContinueWithSettingsUiFlow" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosContinueWithSettingsUiFlow"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, KratosContinueWithSettingsUiFlow kratosContinueWithSettingsUiFlow, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, kratosContinueWithSettingsUiFlow, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="KratosContinueWithSettingsUiFlow" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosContinueWithSettingsUiFlow"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, KratosContinueWithSettingsUiFlow kratosContinueWithSettingsUiFlow, JsonSerializerOptions jsonSerializerOptions)
        {
            if (kratosContinueWithSettingsUiFlow.Id == null)
                throw new ArgumentNullException(nameof(kratosContinueWithSettingsUiFlow.Id), "Property is required for class KratosContinueWithSettingsUiFlow.");

            writer.WriteString("id", kratosContinueWithSettingsUiFlow.Id);
        }
    }
}