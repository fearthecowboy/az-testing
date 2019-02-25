namespace Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json
{
    internal interface IJsonConverter
    {
        JsonNode ToJson(object value);

        object FromJson(JsonNode node);
    }
}