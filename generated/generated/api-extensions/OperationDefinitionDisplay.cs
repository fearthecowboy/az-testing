namespace Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models
{

    /// <summary>The display information for a configuration store operation.</summary>
    [System.ComponentModel.TypeConverter(typeof(OperationDefinitionDisplayTypeConverter))]
    public partial class OperationDefinitionDisplay
    {

        /// <summary>
        /// Creates a new instance of <see cref="OperationDefinitionDisplay" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IOperationDefinitionDisplay FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// The display information for a configuration store operation.
    [System.ComponentModel.TypeConverter(typeof(OperationDefinitionDisplayTypeConverter))]
    public partial interface IOperationDefinitionDisplay {

    }
}