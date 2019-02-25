namespace Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models
{

    /// <summary>The properties of a configuration store.</summary>
    [System.ComponentModel.TypeConverter(typeof(ConfigurationStorePropertiesTypeConverter))]
    public partial class ConfigurationStoreProperties
    {

        /// <summary>
        /// Creates a new instance of <see cref="ConfigurationStoreProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IConfigurationStoreProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// The properties of a configuration store.
    [System.ComponentModel.TypeConverter(typeof(ConfigurationStorePropertiesTypeConverter))]
    public partial interface IConfigurationStoreProperties {

    }
}