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
    /// show_form: No user data has been collected, or it is invalid, and thus the form should be shown. success: Indicates that the settings flow has been updated successfully with the provided data. Done will stay true when repeatedly checking. If set to true, done will revert back to false only when a flow with invalid (e.g. \&quot;please use a valid phone number\&quot;) data was sent.
    /// </summary>
    /// <value>show_form: No user data has been collected, or it is invalid, and thus the form should be shown. success: Indicates that the settings flow has been updated successfully with the provided data. Done will stay true when repeatedly checking. If set to true, done will revert back to false only when a flow with invalid (e.g. \&quot;please use a valid phone number\&quot;) data was sent.</value>
    public enum KratosSettingsFlowState
    {
        /// <summary>
        /// Enum ShowForm for value: show_form
        /// </summary>
        ShowForm,

        /// <summary>
        /// Enum Success for value: success
        /// </summary>
        Success
    }

    /// <summary>
    /// Converts <see cref="KratosSettingsFlowState"/> to and from the JSON value
    /// </summary>
    public static class KratosSettingsFlowStateValueConverter
    {
        /// <summary>
        /// Parses a given value to <see cref="KratosSettingsFlowState"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static KratosSettingsFlowState FromString(string value)
        {
            if (value.Equals("show_form"))
                return KratosSettingsFlowState.ShowForm;

            if (value.Equals("success"))
                return KratosSettingsFlowState.Success;

            throw new NotImplementedException($"Could not convert value to type KratosSettingsFlowState: '{value}'");
        }

        /// <summary>
        /// Parses a given value to <see cref="KratosSettingsFlowState"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static KratosSettingsFlowState? FromStringOrDefault(string value)
        {
            if (value.Equals("show_form"))
                return KratosSettingsFlowState.ShowForm;

            if (value.Equals("success"))
                return KratosSettingsFlowState.Success;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="KratosSettingsFlowState"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string ToJsonValue(KratosSettingsFlowState value)
        {
            if (value == KratosSettingsFlowState.ShowForm)
                return "show_form";

            if (value == KratosSettingsFlowState.Success)
                return "success";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="KratosSettingsFlowState"/>
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
    public class KratosSettingsFlowStateJsonConverter : JsonConverter<KratosSettingsFlowState>
    {
        /// <summary>
        /// Returns a  from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override KratosSettingsFlowState Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? rawValue = reader.GetString();

            KratosSettingsFlowState? result = rawValue == null
                ? null
                : KratosSettingsFlowStateValueConverter.FromStringOrDefault(rawValue);

            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the KratosSettingsFlowState to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosSettingsFlowState"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, KratosSettingsFlowState kratosSettingsFlowState, JsonSerializerOptions options)
        {
            writer.WriteStringValue(kratosSettingsFlowState.ToString());
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="KratosSettingsFlowState"/>
    /// </summary>
    public class KratosSettingsFlowStateNullableJsonConverter : JsonConverter<KratosSettingsFlowState?>
    {
        /// <summary>
        /// Returns a KratosSettingsFlowState from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override KratosSettingsFlowState? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? rawValue = reader.GetString();

            KratosSettingsFlowState? result = rawValue == null
                ? null
                : KratosSettingsFlowStateValueConverter.FromStringOrDefault(rawValue);

            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the DateTime to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="kratosSettingsFlowState"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, KratosSettingsFlowState? kratosSettingsFlowState, JsonSerializerOptions options)
        {
            writer.WriteStringValue(kratosSettingsFlowState?.ToString() ?? "null");
        }
    }
}
