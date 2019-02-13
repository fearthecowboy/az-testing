namespace Microsoft.Azure.AzConfig.Models
{

    /// <summary>
    /// The configuration store along with all resource properties. The Configuration Store will have all information to begin
    /// utlizing it.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(ConfigurationStoreTypeConverter))]
    public partial class ConfigurationStore
    {

        /// <summary>
        /// Creates a new instance of <see cref="ConfigurationStore" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.AzConfig.Models.IConfigurationStore FromJsonString(string jsonText) => FromJson(Microsoft.Azure.AzConfig.Runtime.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.AzConfig.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// The configuration store along with all resource properties. The Configuration Store will have all information to begin
    /// utlizing it.
    [System.ComponentModel.TypeConverter(typeof(ConfigurationStoreTypeConverter))]
    public partial interface IConfigurationStore {

    }
}