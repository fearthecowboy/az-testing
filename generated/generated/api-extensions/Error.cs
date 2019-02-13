namespace Microsoft.Azure.AzConfig.Models
{

    /// <summary>
    /// Error response indicates Logic service is not able to process the incoming request. The error property contains the error
    /// details.
    /// </summary>
    [System.ComponentModel.TypeConverter(typeof(ErrorTypeConverter))]
    public partial class Error
    {

        /// <summary>
        /// Creates a new instance of <see cref="Error" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.AzConfig.Models.IError FromJsonString(string jsonText) => FromJson(Microsoft.Azure.AzConfig.Runtime.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.AzConfig.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Error response indicates Logic service is not able to process the incoming request. The error property contains the error
    /// details.
    [System.ComponentModel.TypeConverter(typeof(ErrorTypeConverter))]
    public partial interface IError {

    }
}