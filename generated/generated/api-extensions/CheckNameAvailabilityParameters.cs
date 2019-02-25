namespace Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models
{

    /// <summary>Parameters used for checking whether a resource name is available.</summary>
    [System.ComponentModel.TypeConverter(typeof(CheckNameAvailabilityParametersTypeConverter))]
    public partial class CheckNameAvailabilityParameters
    {

        /// <summary>
        /// Creates a new instance of <see cref="CheckNameAvailabilityParameters" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.ICheckNameAvailabilityParameters FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// Parameters used for checking whether a resource name is available.
    [System.ComponentModel.TypeConverter(typeof(CheckNameAvailabilityParametersTypeConverter))]
    public partial interface ICheckNameAvailabilityParameters {

    }
}