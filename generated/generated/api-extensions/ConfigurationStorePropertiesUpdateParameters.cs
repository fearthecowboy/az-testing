namespace Microsoft.Azure.AzConfig.Models
{

    /// <summary>The properties for updating a configuration store.</summary>
    [System.ComponentModel.TypeConverter(typeof(ConfigurationStorePropertiesUpdateParametersTypeConverter))]
    public partial class ConfigurationStorePropertiesUpdateParameters
    {

        /// <summary>
        /// Creates a new instance of <see cref="ConfigurationStorePropertiesUpdateParameters" />, deserializing the content from
        /// a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.AzConfig.Models.IConfigurationStorePropertiesUpdateParameters FromJsonString(string jsonText) => FromJson(Microsoft.Azure.AzConfig.Runtime.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.AzConfig.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// The properties for updating a configuration store.
    [System.ComponentModel.TypeConverter(typeof(ConfigurationStorePropertiesUpdateParametersTypeConverter))]
    public partial interface IConfigurationStorePropertiesUpdateParameters {

    }
}