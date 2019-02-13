namespace Microsoft.Azure.AzConfig.Models
{

    /// <summary>The parameters used to regenerate an API key.</summary>
    [System.ComponentModel.TypeConverter(typeof(RegenerateKeyParametersTypeConverter))]
    public partial class RegenerateKeyParameters
    {

        /// <summary>
        /// Creates a new instance of <see cref="RegenerateKeyParameters" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.AzConfig.Models.IRegenerateKeyParameters FromJsonString(string jsonText) => FromJson(Microsoft.Azure.AzConfig.Runtime.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.AzConfig.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// The parameters used to regenerate an API key.
    [System.ComponentModel.TypeConverter(typeof(RegenerateKeyParametersTypeConverter))]
    public partial interface IRegenerateKeyParameters {

    }
}