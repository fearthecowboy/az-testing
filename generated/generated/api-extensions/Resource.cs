namespace Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models
{

    /// <summary>An Azure resource.</summary>
    [System.ComponentModel.TypeConverter(typeof(ResourceTypeConverter))]
    public partial class Resource
    {

        /// <summary>
        /// Creates a new instance of <see cref="Resource" />, deserializing the content from a json string.
        /// </summary>
        /// <param name="jsonText">a string containing a JSON serialized instance of this model.</param>
        /// <returns>an instance of the <see cref="className" /> model class.</returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IResource FromJsonString(string jsonText) => FromJson(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonNode.Parse(jsonText));
        /// <summary>Serializes this instance to a json string.</summary>
        /// <returns>a <see cref="System.String" /> containing this model serialized to JSON text.</returns>
        public string ToJsonString() => ToJson(null, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.SerializationMode.IncludeAll)?.ToString();
    }
    /// An Azure resource.
    [System.ComponentModel.TypeConverter(typeof(ResourceTypeConverter))]
    public partial interface IResource {

    }
}