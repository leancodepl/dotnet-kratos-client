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
    /// Update Settings Flow Request Body
    /// </summary>
    public partial class KratosUpdateSettingsFlowBody
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KratosUpdateSettingsFlowBody" /> class.
        /// </summary>
        /// <param name="kratosUpdateSettingsFlowWithPasswordMethod"></param>
        public KratosUpdateSettingsFlowBody(KratosUpdateSettingsFlowWithPasswordMethod kratosUpdateSettingsFlowWithPasswordMethod)
        {
            KratosUpdateSettingsFlowWithPasswordMethod = kratosUpdateSettingsFlowWithPasswordMethod;
            OnCreated();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KratosUpdateSettingsFlowBody" /> class.
        /// </summary>
        /// <param name="kratosUpdateSettingsFlowWithProfileMethod"></param>
        public KratosUpdateSettingsFlowBody(KratosUpdateSettingsFlowWithProfileMethod kratosUpdateSettingsFlowWithProfileMethod)
        {
            KratosUpdateSettingsFlowWithProfileMethod = kratosUpdateSettingsFlowWithProfileMethod;
            OnCreated();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KratosUpdateSettingsFlowBody" /> class.
        /// </summary>
        /// <param name="kratosUpdateSettingsFlowWithOidcMethod"></param>
        public KratosUpdateSettingsFlowBody(KratosUpdateSettingsFlowWithOidcMethod kratosUpdateSettingsFlowWithOidcMethod)
        {
            KratosUpdateSettingsFlowWithOidcMethod = kratosUpdateSettingsFlowWithOidcMethod;
            OnCreated();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KratosUpdateSettingsFlowBody" /> class.
        /// </summary>
        /// <param name="kratosUpdateSettingsFlowWithTotpMethod"></param>
        public KratosUpdateSettingsFlowBody(KratosUpdateSettingsFlowWithTotpMethod kratosUpdateSettingsFlowWithTotpMethod)
        {
            KratosUpdateSettingsFlowWithTotpMethod = kratosUpdateSettingsFlowWithTotpMethod;
            OnCreated();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KratosUpdateSettingsFlowBody" /> class.
        /// </summary>
        /// <param name="kratosUpdateSettingsFlowWithWebAuthnMethod"></param>
        public KratosUpdateSettingsFlowBody(KratosUpdateSettingsFlowWithWebAuthnMethod kratosUpdateSettingsFlowWithWebAuthnMethod)
        {
            KratosUpdateSettingsFlowWithWebAuthnMethod = kratosUpdateSettingsFlowWithWebAuthnMethod;
            OnCreated();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KratosUpdateSettingsFlowBody" /> class.
        /// </summary>
        /// <param name="kratosUpdateSettingsFlowWithLookupMethod"></param>
        public KratosUpdateSettingsFlowBody(KratosUpdateSettingsFlowWithLookupMethod kratosUpdateSettingsFlowWithLookupMethod)
        {
            KratosUpdateSettingsFlowWithLookupMethod = kratosUpdateSettingsFlowWithLookupMethod;
            OnCreated();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KratosUpdateSettingsFlowBody" /> class.
        /// </summary>
        /// <param name="kratosUpdateSettingsFlowWithPasskeyMethod"></param>
        public KratosUpdateSettingsFlowBody(KratosUpdateSettingsFlowWithPasskeyMethod kratosUpdateSettingsFlowWithPasskeyMethod)
        {
            KratosUpdateSettingsFlowWithPasskeyMethod = kratosUpdateSettingsFlowWithPasskeyMethod;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets KratosUpdateSettingsFlowWithPasswordMethod
        /// </summary>
        public KratosUpdateSettingsFlowWithPasswordMethod? KratosUpdateSettingsFlowWithPasswordMethod { get; set; }

        /// <summary>
        /// Gets or Sets KratosUpdateSettingsFlowWithProfileMethod
        /// </summary>
        public KratosUpdateSettingsFlowWithProfileMethod? KratosUpdateSettingsFlowWithProfileMethod { get; set; }

        /// <summary>
        /// Gets or Sets KratosUpdateSettingsFlowWithOidcMethod
        /// </summary>
        public KratosUpdateSettingsFlowWithOidcMethod? KratosUpdateSettingsFlowWithOidcMethod { get; set; }

        /// <summary>
        /// Gets or Sets KratosUpdateSettingsFlowWithTotpMethod
        /// </summary>
        public KratosUpdateSettingsFlowWithTotpMethod? KratosUpdateSettingsFlowWithTotpMethod { get; set; }

        /// <summary>
        /// Gets or Sets KratosUpdateSettingsFlowWithWebAuthnMethod
        /// </summary>
        public KratosUpdateSettingsFlowWithWebAuthnMethod? KratosUpdateSettingsFlowWithWebAuthnMethod { get; set; }

        /// <summary>
        /// Gets or Sets KratosUpdateSettingsFlowWithLookupMethod
        /// </summary>
        public KratosUpdateSettingsFlowWithLookupMethod? KratosUpdateSettingsFlowWithLookupMethod { get; set; }

        /// <summary>
        /// Gets or Sets KratosUpdateSettingsFlowWithPasskeyMethod
        /// </summary>
        public KratosUpdateSettingsFlowWithPasskeyMethod? KratosUpdateSettingsFlowWithPasskeyMethod { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class KratosUpdateSettingsFlowBody {\n");
            sb.Append("}\n");
            return sb.ToString();
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="KratosUpdateSettingsFlowBody" />
    /// </summary>
    public class KratosUpdateSettingsFlowBodyJsonConverter : JsonConverter<KratosUpdateSettingsFlowBody>
    {
        /// <summary>
        /// Deserializes json to <see cref="KratosUpdateSettingsFlowBody" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override KratosUpdateSettingsFlowBody Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> method = default;

            Utf8JsonReader utf8JsonReaderDiscriminator = utf8JsonReader;
            while (utf8JsonReaderDiscriminator.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReaderDiscriminator.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReaderDiscriminator.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReaderDiscriminator.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReaderDiscriminator.CurrentDepth)
                    break;

                if (utf8JsonReaderDiscriminator.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReaderDiscriminator.CurrentDepth - 1)
                {
                    string? localVarJsonPropertyName = utf8JsonReaderDiscriminator.GetString();
                    utf8JsonReaderDiscriminator.Read();
                    if (localVarJsonPropertyName?.Equals("method") ?? false)
                    {
                        string? discriminator = utf8JsonReaderDiscriminator.GetString();
                        if (discriminator?.Equals("lookup_secret") ?? false)
                        {
                            Utf8JsonReader utf8JsonReader = utf8JsonReader;
                             = JsonSerializer.Deserialize<>(ref utf8JsonReader, jsonSerializerOptions);
                        }
                        if (discriminator?.Equals("oidc") ?? false)
                        {
                            Utf8JsonReader utf8JsonReader = utf8JsonReader;
                             = JsonSerializer.Deserialize<>(ref utf8JsonReader, jsonSerializerOptions);
                        }
                        if (discriminator?.Equals("passkey") ?? false)
                        {
                            Utf8JsonReader utf8JsonReader = utf8JsonReader;
                             = JsonSerializer.Deserialize<>(ref utf8JsonReader, jsonSerializerOptions);
                        }
                        if (discriminator?.Equals("password") ?? false)
                        {
                            Utf8JsonReader utf8JsonReader = utf8JsonReader;
                             = JsonSerializer.Deserialize<>(ref utf8JsonReader, jsonSerializerOptions);
                        }
                        if (discriminator?.Equals("profile") ?? false)
                        {
                            Utf8JsonReader utf8JsonReader = utf8JsonReader;
                             = JsonSerializer.Deserialize<>(ref utf8JsonReader, jsonSerializerOptions);
                        }
                        if (discriminator?.Equals("totp") ?? false)
                        {
                            Utf8JsonReader utf8JsonReader = utf8JsonReader;
                             = JsonSerializer.Deserialize<>(ref utf8JsonReader, jsonSerializerOptions);
                        }
                        if (discriminator?.Equals("webauthn") ?? false)
                        {
                            Utf8JsonReader utf8JsonReader = utf8JsonReader;
                             = JsonSerializer.Deserialize<>(ref utf8JsonReader, jsonSerializerOptions);
                        }
                        if (discriminator?.Equals("updateSettingsFlowWithLookupMethod") ?? false)
                        {
                            Utf8JsonReader utf8JsonReader = utf8JsonReader;
                             = JsonSerializer.Deserialize<>(ref utf8JsonReader, jsonSerializerOptions);
                        }
                        if (discriminator?.Equals("updateSettingsFlowWithOidcMethod") ?? false)
                        {
                            Utf8JsonReader utf8JsonReader = utf8JsonReader;
                             = JsonSerializer.Deserialize<>(ref utf8JsonReader, jsonSerializerOptions);
                        }
                        if (discriminator?.Equals("updateSettingsFlowWithPasskeyMethod") ?? false)
                        {
                            Utf8JsonReader utf8JsonReader = utf8JsonReader;
                             = JsonSerializer.Deserialize<>(ref utf8JsonReader, jsonSerializerOptions);
                        }
                        if (discriminator?.Equals("updateSettingsFlowWithPasswordMethod") ?? false)
                        {
                            Utf8JsonReader utf8JsonReader = utf8JsonReader;
                             = JsonSerializer.Deserialize<>(ref utf8JsonReader, jsonSerializerOptions);
                        }
                        if (discriminator?.Equals("updateSettingsFlowWithProfileMethod") ?? false)
                        {
                            Utf8JsonReader utf8JsonReader = utf8JsonReader;
                             = JsonSerializer.Deserialize<>(ref utf8JsonReader, jsonSerializerOptions);
                        }
                        if (discriminator?.Equals("updateSettingsFlowWithTotpMethod") ?? false)
                        {
                            Utf8JsonReader utf8JsonReader = utf8JsonReader;
                             = JsonSerializer.Deserialize<>(ref utf8JsonReader, jsonSerializerOptions);
                        }
                        if (discriminator?.Equals("updateSettingsFlowWithWebAuthnMethod") ?? false)
                        {
                            Utf8JsonReader utf8JsonReader = utf8JsonReader;
                             = JsonSerializer.Deserialize<>(ref utf8JsonReader, jsonSerializerOptions);
                        }
                    }
                }
            }

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
                        case "method":
                            method = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!method.IsSet)
                throw new ArgumentException("Property is required for class KratosUpdateSettingsFlowBody.", nameof(method));

            if (method.IsSet && method.Value == null)
                throw new ArgumentNullException(nameof(method), "Property is not nullable for class KratosUpdateSettingsFlowBody.");

            if ( != null)
                return new KratosUpdateSettingsFlowBody();

            if ( != null)
                return new KratosUpdateSettingsFlowBody();

            if ( != null)
                return new KratosUpdateSettingsFlowBody();

            if ( != null)
                return new KratosUpdateSettingsFlowBody();

            if ( != null)
                return new KratosUpdateSettingsFlowBody();

            if ( != null)
                return new KratosUpdateSettingsFlowBody();

            if ( != null)
                return new KratosUpdateSettingsFlowBody();

            if ( != null)
                return new KratosUpdateSettingsFlowBody();

            if ( != null)
                return new KratosUpdateSettingsFlowBody();

            if ( != null)
                return new KratosUpdateSettingsFlowBody();

            if ( != null)
                return new KratosUpdateSettingsFlowBody();

            if ( != null)
                return new KratosUpdateSettingsFlowBody();

            if ( != null)
                return new KratosUpdateSettingsFlowBody();

            if ( != null)
                return new KratosUpdateSettingsFlowBody();

            throw new JsonException();
        }

        /// <summary>
        /// Serializes a <see cref="KratosUpdateSettingsFlowBody" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosUpdateSettingsFlowBody"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, KratosUpdateSettingsFlowBody kratosUpdateSettingsFlowBody, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            if (kratosUpdateSettingsFlowBody.KratosUpdateSettingsFlowWithPasswordMethod != null)
            {
                KratosUpdateSettingsFlowWithPasswordMethodJsonConverter kratosUpdateSettingsFlowWithPasswordMethodJsonConverter = (KratosUpdateSettingsFlowWithPasswordMethodJsonConverter) jsonSerializerOptions.Converters.First(c => c.CanConvert(kratosUpdateSettingsFlowBody.KratosUpdateSettingsFlowWithPasswordMethod.GetType()));
                kratosUpdateSettingsFlowWithPasswordMethodJsonConverter.WriteProperties(writer, kratosUpdateSettingsFlowBody.KratosUpdateSettingsFlowWithPasswordMethod, jsonSerializerOptions);
            }

            if (kratosUpdateSettingsFlowBody.KratosUpdateSettingsFlowWithProfileMethod != null)
            {
                KratosUpdateSettingsFlowWithProfileMethodJsonConverter kratosUpdateSettingsFlowWithProfileMethodJsonConverter = (KratosUpdateSettingsFlowWithProfileMethodJsonConverter) jsonSerializerOptions.Converters.First(c => c.CanConvert(kratosUpdateSettingsFlowBody.KratosUpdateSettingsFlowWithProfileMethod.GetType()));
                kratosUpdateSettingsFlowWithProfileMethodJsonConverter.WriteProperties(writer, kratosUpdateSettingsFlowBody.KratosUpdateSettingsFlowWithProfileMethod, jsonSerializerOptions);
            }

            if (kratosUpdateSettingsFlowBody.KratosUpdateSettingsFlowWithOidcMethod != null)
            {
                KratosUpdateSettingsFlowWithOidcMethodJsonConverter kratosUpdateSettingsFlowWithOidcMethodJsonConverter = (KratosUpdateSettingsFlowWithOidcMethodJsonConverter) jsonSerializerOptions.Converters.First(c => c.CanConvert(kratosUpdateSettingsFlowBody.KratosUpdateSettingsFlowWithOidcMethod.GetType()));
                kratosUpdateSettingsFlowWithOidcMethodJsonConverter.WriteProperties(writer, kratosUpdateSettingsFlowBody.KratosUpdateSettingsFlowWithOidcMethod, jsonSerializerOptions);
            }

            if (kratosUpdateSettingsFlowBody.KratosUpdateSettingsFlowWithTotpMethod != null)
            {
                KratosUpdateSettingsFlowWithTotpMethodJsonConverter kratosUpdateSettingsFlowWithTotpMethodJsonConverter = (KratosUpdateSettingsFlowWithTotpMethodJsonConverter) jsonSerializerOptions.Converters.First(c => c.CanConvert(kratosUpdateSettingsFlowBody.KratosUpdateSettingsFlowWithTotpMethod.GetType()));
                kratosUpdateSettingsFlowWithTotpMethodJsonConverter.WriteProperties(writer, kratosUpdateSettingsFlowBody.KratosUpdateSettingsFlowWithTotpMethod, jsonSerializerOptions);
            }

            if (kratosUpdateSettingsFlowBody.KratosUpdateSettingsFlowWithWebAuthnMethod != null)
            {
                KratosUpdateSettingsFlowWithWebAuthnMethodJsonConverter kratosUpdateSettingsFlowWithWebAuthnMethodJsonConverter = (KratosUpdateSettingsFlowWithWebAuthnMethodJsonConverter) jsonSerializerOptions.Converters.First(c => c.CanConvert(kratosUpdateSettingsFlowBody.KratosUpdateSettingsFlowWithWebAuthnMethod.GetType()));
                kratosUpdateSettingsFlowWithWebAuthnMethodJsonConverter.WriteProperties(writer, kratosUpdateSettingsFlowBody.KratosUpdateSettingsFlowWithWebAuthnMethod, jsonSerializerOptions);
            }

            if (kratosUpdateSettingsFlowBody.KratosUpdateSettingsFlowWithLookupMethod != null)
            {
                KratosUpdateSettingsFlowWithLookupMethodJsonConverter kratosUpdateSettingsFlowWithLookupMethodJsonConverter = (KratosUpdateSettingsFlowWithLookupMethodJsonConverter) jsonSerializerOptions.Converters.First(c => c.CanConvert(kratosUpdateSettingsFlowBody.KratosUpdateSettingsFlowWithLookupMethod.GetType()));
                kratosUpdateSettingsFlowWithLookupMethodJsonConverter.WriteProperties(writer, kratosUpdateSettingsFlowBody.KratosUpdateSettingsFlowWithLookupMethod, jsonSerializerOptions);
            }

            if (kratosUpdateSettingsFlowBody.KratosUpdateSettingsFlowWithPasskeyMethod != null)
            {
                KratosUpdateSettingsFlowWithPasskeyMethodJsonConverter kratosUpdateSettingsFlowWithPasskeyMethodJsonConverter = (KratosUpdateSettingsFlowWithPasskeyMethodJsonConverter) jsonSerializerOptions.Converters.First(c => c.CanConvert(kratosUpdateSettingsFlowBody.KratosUpdateSettingsFlowWithPasskeyMethod.GetType()));
                kratosUpdateSettingsFlowWithPasskeyMethodJsonConverter.WriteProperties(writer, kratosUpdateSettingsFlowBody.KratosUpdateSettingsFlowWithPasskeyMethod, jsonSerializerOptions);
            }

            WriteProperties(writer, kratosUpdateSettingsFlowBody, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="KratosUpdateSettingsFlowBody" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosUpdateSettingsFlowBody"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(Utf8JsonWriter writer, KratosUpdateSettingsFlowBody kratosUpdateSettingsFlowBody, JsonSerializerOptions jsonSerializerOptions)
        {

        }
    }
}
