namespace Microsoft.Azure.AzConfig.Models
{

    /// <summary>The result of a request to list configuration stores.</summary>
    [System.ComponentModel.TypeConverter(typeof(ConfigurationStoreListResultTypeConverter))]
    public partial class ConfigurationStoreListResult
    {

        /// <summary>
        /// Creates a new instance of <see cref="ConfigurationStoreListResult" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.AzConfig.Models.IConfigurationStoreListResult FromJsonString(string jsonText) => FromJson(Microsoft.Azure.AzConfig.Runtime.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.AzConfig.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// The result of a request to list configuration stores.
    [System.ComponentModel.TypeConverter(typeof(ConfigurationStoreListResultTypeConverter))]
    public partial interface IConfigurationStoreListResult {

    }
}