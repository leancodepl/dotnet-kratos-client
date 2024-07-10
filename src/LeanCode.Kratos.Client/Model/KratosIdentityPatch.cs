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
    /// Payload for patching an identity
    /// </summary>
    public partial class KratosIdentityPatch
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosIdentityPatch" /> class.
        /// </summary>
        /// <param name="create">create</param>
        /// <param name="patchId">The ID of this patch.  The patch ID is optional. If specified, the ID will be returned in the response, so consumers of this API can correlate the response with the patch.</param>
        [JsonConstructor]
        public KratosIdentityPatch(Option<KratosCreateIdentityBody?> create = default, Option<string?> patchId = default)
        {
            CreateOption = create;
            PatchIdOption = patchId;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Used to track the state of Create
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<KratosCreateIdentityBody?> CreateOption { get; private set; }

        /// <summary>
        /// Gets or Sets Create
        /// </summary>
        [JsonPropertyName("create")]
        public KratosCreateIdentityBody? Create { get { return this.CreateOption; } set { this.CreateOption = new(value); } }

        /// <summary>
        /// Used to track the state of PatchId
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<string?> PatchIdOption { get; private set; }

        /// <summary>
        /// The ID of this patch.  The patch ID is optional. If specified, the ID will be returned in the response, so consumers of this API can correlate the response with the patch.
        /// </summary>
        /// <value>The ID of this patch.  The patch ID is optional. If specified, the ID will be returned in the response, so consumers of this API can correlate the response with the patch.</value>
        [JsonPropertyName("patch_id")]
        public string? PatchId { get { return this.PatchIdOption; } set { this.PatchIdOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class KratosIdentityPatch {\n");
            sb.Append("  Create: ").Append(Create).Append("\n");
            sb.Append("  PatchId: ").Append(PatchId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="KratosIdentityPatch" />
    /// </summary>
    public class KratosIdentityPatchJsonConverter : JsonConverter<KratosIdentityPatch>
    {
        /// <summary>
        /// Deserializes json to <see cref="KratosIdentityPatch" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override KratosIdentityPatch Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<KratosCreateIdentityBody?> create = default;
            Option<string?> patchId = default;

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
                        case "create":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                create = new Option<KratosCreateIdentityBody?>(JsonSerializer.Deserialize<KratosCreateIdentityBody>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "patch_id":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                patchId = new Option<string?>(utf8JsonReader.GetString());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (create.IsSet && create.Value == null)
                throw new ArgumentNullException(nameof(create), "Property is not nullable for class KratosIdentityPatch.");

            if (patchId.IsSet && patchId.Value == null)
                throw new ArgumentNullException(nameof(patchId), "Property is not nullable for class KratosIdentityPatch.");

            return new KratosIdentityPatch(create, patchId);
        }

        /// <summary>
        /// Serializes a <see cref="KratosIdentityPatch" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosIdentityPatch"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, KratosIdentityPatch kratosIdentityPatch, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, kratosIdentityPatch, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="KratosIdentityPatch" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosIdentityPatch"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, KratosIdentityPatch kratosIdentityPatch, JsonSerializerOptions jsonSerializerOptions)
        {
            if (kratosIdentityPatch.CreateOption.IsSet && kratosIdentityPatch.Create == null)
                throw new ArgumentNullException(nameof(kratosIdentityPatch.Create), "Property is required for class KratosIdentityPatch.");

            if (kratosIdentityPatch.PatchIdOption.IsSet && kratosIdentityPatch.PatchId == null)
                throw new ArgumentNullException(nameof(kratosIdentityPatch.PatchId), "Property is required for class KratosIdentityPatch.");

            if (kratosIdentityPatch.CreateOption.IsSet)
            {
                writer.WritePropertyName("create");
                JsonSerializer.Serialize(writer, kratosIdentityPatch.Create, jsonSerializerOptions);
            }
            if (kratosIdentityPatch.PatchIdOption.IsSet)
                writer.WriteString("patch_id", kratosIdentityPatch.PatchIdOption.Value);
        }
    }
}
