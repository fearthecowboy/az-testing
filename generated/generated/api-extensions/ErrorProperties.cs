namespace Microsoft.Azure.AzConfig.Models
{

    /// <summary>Azconfig error properties.</summary>
    [System.ComponentModel.TypeConverter(typeof(ErrorPropertiesTypeConverter))]
    public partial class ErrorProperties
    {

        /// <summary>
        /// Creates a new instance of <see cref="ErrorProperties" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.AzConfig.Models.IErrorProperties FromJsonString(string jsonText) => FromJson(Microsoft.Azure.AzConfig.Runtime.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.AzConfig.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Azconfig error properties.
    [System.ComponentModel.TypeConverter(typeof(ErrorPropertiesTypeConverter))]
    public partial interface IErrorProperties {

    }
}