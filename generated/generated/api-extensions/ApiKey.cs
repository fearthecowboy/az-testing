namespace Microsoft.Azure.AzConfig.Models
{

    /// <summary>An API key used for authenticating with a configuration store endpoint.</summary>
    [System.ComponentModel.TypeConverter(typeof(ApiKeyTypeConverter))]
    public partial class ApiKey
    {

        /// <summary>
        /// Creates a new instance of <see cref="ApiKey" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.AzConfig.Models.IApiKey FromJsonString(string jsonText) => FromJson(Microsoft.Azure.AzConfig.Runtime.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.AzConfig.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// An API key used for authenticating with a configuration store endpoint.
    [System.ComponentModel.TypeConverter(typeof(ApiKeyTypeConverter))]
    public partial interface IApiKey {

    }
}