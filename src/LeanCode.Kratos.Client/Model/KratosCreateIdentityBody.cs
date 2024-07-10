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
    /// Create Identity Body
    /// </summary>
    public partial class KratosCreateIdentityBody
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosCreateIdentityBody" /> class.
        /// </summary>
        /// <param name="schemaId">SchemaID is the ID of the JSON Schema to be used for validating the identity&#39;s traits.</param>
        /// <param name="traits">Traits represent an identity&#39;s traits. The identity is able to create, modify, and delete traits in a self-service manner. The input will always be validated against the JSON Schema defined in &#x60;schema_url&#x60;.</param>
        /// <param name="credentials">credentials</param>
        /// <param name="metadataAdmin">Store metadata about the user which is only accessible through admin APIs such as &#x60;GET /admin/identities/&lt;id&gt;&#x60;.</param>
        /// <param name="metadataPublic">Store metadata about the identity which the identity itself can see when calling for example the session endpoint. Do not store sensitive information (e.g. credit score) about the identity in this field.</param>
        /// <param name="recoveryAddresses">RecoveryAddresses contains all the addresses that can be used to recover an identity.  Use this structure to import recovery addresses for an identity. Please keep in mind that the address needs to be represented in the Identity Schema or this field will be overwritten on the next identity update.</param>
        /// <param name="state">State is the identity&#39;s state. active StateActive inactive StateInactive</param>
        /// <param name="verifiableAddresses">VerifiableAddresses contains all the addresses that can be verified by the user.  Use this structure to import verified addresses for an identity. Please keep in mind that the address needs to be represented in the Identity Schema or this field will be overwritten on the next identity update.</param>
        [JsonConstructor]
        public KratosCreateIdentityBody(string schemaId, Object traits, Option<KratosIdentityWithCredentials?> credentials = default, Option<Object?> metadataAdmin = default, Option<Object?> metadataPublic = default, Option<List<KratosRecoveryIdentityAddress>?> recoveryAddresses = default, Option<StateEnum?> state = default, Option<List<KratosVerifiableIdentityAddress>?> verifiableAddresses = default)
        {
            SchemaId = schemaId;
            Traits = traits;
            CredentialsOption = credentials;
            MetadataAdminOption = metadataAdmin;
            MetadataPublicOption = metadataPublic;
            RecoveryAddressesOption = recoveryAddresses;
            StateOption = state;
            VerifiableAddressesOption = verifiableAddresses;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// State is the identity&#39;s state. active StateActive inactive StateInactive
        /// </summary>
        /// <value>State is the identity&#39;s state. active StateActive inactive StateInactive</value>
        public enum StateEnum
        {
            /// <summary>
            /// Enum Active for value: active
            /// </summary>
            Active,

            /// <summary>
            /// Enum Inactive for value: inactive
            /// </summary>
            Inactive
        }

        /// <summary>
        /// Returns a <see cref="StateEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static StateEnum StateEnumFromString(string value)
        {
            if (value.Equals("active"))
                return StateEnum.Active;

            if (value.Equals("inactive"))
                return StateEnum.Inactive;

            throw new NotImplementedException($"Could not convert value to type StateEnum: '{value}'");
        }

        /// <summary>
        /// Returns a <see cref="StateEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static StateEnum? StateEnumFromStringOrDefault(string value)
        {
            if (value.Equals("active"))
                return StateEnum.Active;

            if (value.Equals("inactive"))
                return StateEnum.Inactive;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="StateEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string StateEnumToJsonValue(StateEnum? value)
        {
            if (value == StateEnum.Active)
                return "active";

            if (value == StateEnum.Inactive)
                return "inactive";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }

        /// <summary>
        /// Used to track the state of State
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<StateEnum?> StateOption { get; private set; }

        /// <summary>
        /// State is the identity&#39;s state. active StateActive inactive StateInactive
        /// </summary>
        /// <value>State is the identity&#39;s state. active StateActive inactive StateInactive</value>
        [JsonPropertyName("state")]
        public StateEnum? State { get { return this.StateOption; } set { this.StateOption = new(value); } }

        /// <summary>
        /// SchemaID is the ID of the JSON Schema to be used for validating the identity&#39;s traits.
        /// </summary>
        /// <value>SchemaID is the ID of the JSON Schema to be used for validating the identity&#39;s traits.</value>
        [JsonPropertyName("schema_id")]
        public string SchemaId { get; set; }

        /// <summary>
        /// Traits represent an identity&#39;s traits. The identity is able to create, modify, and delete traits in a self-service manner. The input will always be validated against the JSON Schema defined in &#x60;schema_url&#x60;.
        /// </summary>
        /// <value>Traits represent an identity&#39;s traits. The identity is able to create, modify, and delete traits in a self-service manner. The input will always be validated against the JSON Schema defined in &#x60;schema_url&#x60;.</value>
        [JsonPropertyName("traits")]
        public Object Traits { get; set; }

        /// <summary>
        /// Used to track the state of Credentials
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<KratosIdentityWithCredentials?> CredentialsOption { get; private set; }

        /// <summary>
        /// Gets or Sets Credentials
        /// </summary>
        [JsonPropertyName("credentials")]
        public KratosIdentityWithCredentials? Credentials { get { return this.CredentialsOption; } set { this.CredentialsOption = new(value); } }

        /// <summary>
        /// Used to track the state of MetadataAdmin
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Object?> MetadataAdminOption { get; private set; }

        /// <summary>
        /// Store metadata about the user which is only accessible through admin APIs such as &#x60;GET /admin/identities/&lt;id&gt;&#x60;.
        /// </summary>
        /// <value>Store metadata about the user which is only accessible through admin APIs such as &#x60;GET /admin/identities/&lt;id&gt;&#x60;.</value>
        [JsonPropertyName("metadata_admin")]
        public Object? MetadataAdmin { get { return this.MetadataAdminOption; } set { this.MetadataAdminOption = new(value); } }

        /// <summary>
        /// Used to track the state of MetadataPublic
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<Object?> MetadataPublicOption { get; private set; }

        /// <summary>
        /// Store metadata about the identity which the identity itself can see when calling for example the session endpoint. Do not store sensitive information (e.g. credit score) about the identity in this field.
        /// </summary>
        /// <value>Store metadata about the identity which the identity itself can see when calling for example the session endpoint. Do not store sensitive information (e.g. credit score) about the identity in this field.</value>
        [JsonPropertyName("metadata_public")]
        public Object? MetadataPublic { get { return this.MetadataPublicOption; } set { this.MetadataPublicOption = new(value); } }

        /// <summary>
        /// Used to track the state of RecoveryAddresses
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<KratosRecoveryIdentityAddress>?> RecoveryAddressesOption { get; private set; }

        /// <summary>
        /// RecoveryAddresses contains all the addresses that can be used to recover an identity.  Use this structure to import recovery addresses for an identity. Please keep in mind that the address needs to be represented in the Identity Schema or this field will be overwritten on the next identity update.
        /// </summary>
        /// <value>RecoveryAddresses contains all the addresses that can be used to recover an identity.  Use this structure to import recovery addresses for an identity. Please keep in mind that the address needs to be represented in the Identity Schema or this field will be overwritten on the next identity update.</value>
        [JsonPropertyName("recovery_addresses")]
        public List<KratosRecoveryIdentityAddress>? RecoveryAddresses { get { return this.RecoveryAddressesOption; } set { this.RecoveryAddressesOption = new(value); } }

        /// <summary>
        /// Used to track the state of VerifiableAddresses
        /// </summary>
        [JsonIgnore]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public Option<List<KratosVerifiableIdentityAddress>?> VerifiableAddressesOption { get; private set; }

        /// <summary>
        /// VerifiableAddresses contains all the addresses that can be verified by the user.  Use this structure to import verified addresses for an identity. Please keep in mind that the address needs to be represented in the Identity Schema or this field will be overwritten on the next identity update.
        /// </summary>
        /// <value>VerifiableAddresses contains all the addresses that can be verified by the user.  Use this structure to import verified addresses for an identity. Please keep in mind that the address needs to be represented in the Identity Schema or this field will be overwritten on the next identity update.</value>
        [JsonPropertyName("verifiable_addresses")]
        public List<KratosVerifiableIdentityAddress>? VerifiableAddresses { get { return this.VerifiableAddressesOption; } set { this.VerifiableAddressesOption = new(value); } }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class KratosCreateIdentityBody {\n");
            sb.Append("  SchemaId: ").Append(SchemaId).Append("\n");
            sb.Append("  Traits: ").Append(Traits).Append("\n");
            sb.Append("  Credentials: ").Append(Credentials).Append("\n");
            sb.Append("  MetadataAdmin: ").Append(MetadataAdmin).Append("\n");
            sb.Append("  MetadataPublic: ").Append(MetadataPublic).Append("\n");
            sb.Append("  RecoveryAddresses: ").Append(RecoveryAddresses).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  VerifiableAddresses: ").Append(VerifiableAddresses).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="KratosCreateIdentityBody" />
    /// </summary>
    public class KratosCreateIdentityBodyJsonConverter : JsonConverter<KratosCreateIdentityBody>
    {
        /// <summary>
        /// Deserializes json to <see cref="KratosCreateIdentityBody" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override KratosCreateIdentityBody Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> schemaId = default;
            Option<Object?> traits = default;
            Option<KratosIdentityWithCredentials?> credentials = default;
            Option<Object?> metadataAdmin = default;
            Option<Object?> metadataPublic = default;
            Option<List<KratosRecoveryIdentityAddress>?> recoveryAddresses = default;
            Option<KratosCreateIdentityBody.StateEnum?> state = default;
            Option<List<KratosVerifiableIdentityAddress>?> verifiableAddresses = default;

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
                        case "schema_id":
                            schemaId = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "traits":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                traits = new Option<Object?>(JsonSerializer.Deserialize<Object>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "credentials":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                credentials = new Option<KratosIdentityWithCredentials?>(JsonSerializer.Deserialize<KratosIdentityWithCredentials>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "metadata_admin":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                metadataAdmin = new Option<Object?>(JsonSerializer.Deserialize<Object>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "metadata_public":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                metadataPublic = new Option<Object?>(JsonSerializer.Deserialize<Object>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "recovery_addresses":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                recoveryAddresses = new Option<List<KratosRecoveryIdentityAddress>?>(JsonSerializer.Deserialize<List<KratosRecoveryIdentityAddress>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "state":
                            string? stateRawValue = utf8JsonReader.GetString();
                            if (stateRawValue != null)
                                state = new Option<KratosCreateIdentityBody.StateEnum?>(KratosCreateIdentityBody.StateEnumFromStringOrDefault(stateRawValue));
                            break;
                        case "verifiable_addresses":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                verifiableAddresses = new Option<List<KratosVerifiableIdentityAddress>?>(JsonSerializer.Deserialize<List<KratosVerifiableIdentityAddress>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!schemaId.IsSet)
                throw new ArgumentException("Property is required for class KratosCreateIdentityBody.", nameof(schemaId));

            if (!traits.IsSet)
                throw new ArgumentException("Property is required for class KratosCreateIdentityBody.", nameof(traits));

            if (schemaId.IsSet && schemaId.Value == null)
                throw new ArgumentNullException(nameof(schemaId), "Property is not nullable for class KratosCreateIdentityBody.");

            if (traits.IsSet && traits.Value == null)
                throw new ArgumentNullException(nameof(traits), "Property is not nullable for class KratosCreateIdentityBody.");

            if (credentials.IsSet && credentials.Value == null)
                throw new ArgumentNullException(nameof(credentials), "Property is not nullable for class KratosCreateIdentityBody.");

            if (recoveryAddresses.IsSet && recoveryAddresses.Value == null)
                throw new ArgumentNullException(nameof(recoveryAddresses), "Property is not nullable for class KratosCreateIdentityBody.");

            if (state.IsSet && state.Value == null)
                throw new ArgumentNullException(nameof(state), "Property is not nullable for class KratosCreateIdentityBody.");

            if (verifiableAddresses.IsSet && verifiableAddresses.Value == null)
                throw new ArgumentNullException(nameof(verifiableAddresses), "Property is not nullable for class KratosCreateIdentityBody.");

            return new KratosCreateIdentityBody(schemaId.Value!, traits.Value!, credentials, metadataAdmin, metadataPublic, recoveryAddresses, state, verifiableAddresses);
        }

        /// <summary>
        /// Serializes a <see cref="KratosCreateIdentityBody" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosCreateIdentityBody"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, KratosCreateIdentityBody kratosCreateIdentityBody, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(writer, kratosCreateIdentityBody, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="KratosCreateIdentityBody" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosCreateIdentityBody"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, KratosCreateIdentityBody kratosCreateIdentityBody, JsonSerializerOptions jsonSerializerOptions)
        {
            if (kratosCreateIdentityBody.SchemaId == null)
                throw new ArgumentNullException(nameof(kratosCreateIdentityBody.SchemaId), "Property is required for class KratosCreateIdentityBody.");

            if (kratosCreateIdentityBody.Traits == null)
                throw new ArgumentNullException(nameof(kratosCreateIdentityBody.Traits), "Property is required for class KratosCreateIdentityBody.");

            if (kratosCreateIdentityBody.CredentialsOption.IsSet && kratosCreateIdentityBody.Credentials == null)
                throw new ArgumentNullException(nameof(kratosCreateIdentityBody.Credentials), "Property is required for class KratosCreateIdentityBody.");

            if (kratosCreateIdentityBody.RecoveryAddressesOption.IsSet && kratosCreateIdentityBody.RecoveryAddresses == null)
                throw new ArgumentNullException(nameof(kratosCreateIdentityBody.RecoveryAddresses), "Property is required for class KratosCreateIdentityBody.");

            if (kratosCreateIdentityBody.VerifiableAddressesOption.IsSet && kratosCreateIdentityBody.VerifiableAddresses == null)
                throw new ArgumentNullException(nameof(kratosCreateIdentityBody.VerifiableAddresses), "Property is required for class KratosCreateIdentityBody.");

            writer.WriteString("schema_id", kratosCreateIdentityBody.SchemaId);

            writer.WritePropertyName("traits");
            JsonSerializer.Serialize(writer, kratosCreateIdentityBody.Traits, jsonSerializerOptions);
            if (kratosCreateIdentityBody.CredentialsOption.IsSet)
            {
                writer.WritePropertyName("credentials");
                JsonSerializer.Serialize(writer, kratosCreateIdentityBody.Credentials, jsonSerializerOptions);
            }
            if (kratosCreateIdentityBody.MetadataAdminOption.IsSet)
                if (kratosCreateIdentityBody.MetadataAdminOption.Value != null)
                {
                    writer.WritePropertyName("metadata_admin");
                    JsonSerializer.Serialize(writer, kratosCreateIdentityBody.MetadataAdmin, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("metadata_admin");
            if (kratosCreateIdentityBody.MetadataPublicOption.IsSet)
                if (kratosCreateIdentityBody.MetadataPublicOption.Value != null)
                {
                    writer.WritePropertyName("metadata_public");
                    JsonSerializer.Serialize(writer, kratosCreateIdentityBody.MetadataPublic, jsonSerializerOptions);
                }
                else
                    writer.WriteNull("metadata_public");
            if (kratosCreateIdentityBody.RecoveryAddressesOption.IsSet)
            {
                writer.WritePropertyName("recovery_addresses");
                JsonSerializer.Serialize(writer, kratosCreateIdentityBody.RecoveryAddresses, jsonSerializerOptions);
            }
            var stateRawValue = KratosCreateIdentityBody.StateEnumToJsonValue(kratosCreateIdentityBody.StateOption.Value!.Value);
            writer.WriteString("state", stateRawValue);
            if (kratosCreateIdentityBody.VerifiableAddressesOption.IsSet)
            {
                writer.WritePropertyName("verifiable_addresses");
                JsonSerializer.Serialize(writer, kratosCreateIdentityBody.VerifiableAddresses, jsonSerializerOptions);
            }
        }
    }
}
