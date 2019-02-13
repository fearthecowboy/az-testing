namespace Microsoft.Azure.AzConfig.Models
{
    using static Microsoft.Azure.AzConfig.Runtime.Extensions;
    /// <summary>The parameters for updating a configuration store.</summary>
    public partial class ConfigurationStoreUpdateParameters
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        partial void AfterFromJson(Microsoft.Azure.AzConfig.Runtime.Json.JsonObject json);
        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.AzConfig.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        partial void AfterToJson(ref Microsoft.Azure.AzConfig.Runtime.Json.JsonObject container);
        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>
        partial void BeforeFromJson(Microsoft.Azure.AzConfig.Runtime.Json.JsonObject json, ref bool returnNow);
        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>
        partial void BeforeToJson(ref Microsoft.Azure.AzConfig.Runtime.Json.JsonObject container, ref bool returnNow);
        /// <summary>
        /// Deserializes a Microsoft.Azure.AzConfig.Runtime.Json.JsonObject into a new instance of <see cref="ConfigurationStoreUpdateParameters" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.AzConfig.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal ConfigurationStoreUpdateParameters(Microsoft.Azure.AzConfig.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            _properties = If( json?.PropertyT<Microsoft.Azure.AzConfig.Runtime.Json.JsonObject>("properties"), out var __jsonProperties) ? Microsoft.Azure.AzConfig.Models.ConfigurationStorePropertiesUpdateParameters.FromJson(__jsonProperties) : Properties;
            _tag = /* 1 */ new System.Collections.Hashtable( System.Linq.Enumerable.ToDictionary<string,string, string>( json.Property("tags")?.Keys ?? System.Linq.Enumerable.Empty<string>(), each => each, each => json.Property("tags").PropertyT<Microsoft.Azure.AzConfig.Runtime.Json.JsonNode>(each) is Microsoft.Azure.AzConfig.Runtime.Json.JsonString __t ? (string)__t : null ));
            AfterFromJson(json);
        }
        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.AzConfig.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.AzConfig.Models.IConfigurationStoreUpdateParameters.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.AzConfig.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.AzConfig.Models.IConfigurationStoreUpdateParameters.
        /// </returns>
        public static Microsoft.Azure.AzConfig.Models.IConfigurationStoreUpdateParameters FromJson(Microsoft.Azure.AzConfig.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.AzConfig.Runtime.Json.JsonObject json ? new ConfigurationStoreUpdateParameters(json) : null;
        }
        /// <summary>
        /// Serializes this instance of <see cref="ConfigurationStoreUpdateParameters" /> into a <see cref="Microsoft.Azure.AzConfig.Runtime.Json.JsonNode"
        /// />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.AzConfig.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.AzConfig.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="ConfigurationStoreUpdateParameters" /> as a <see cref="Microsoft.Azure.AzConfig.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.AzConfig.Runtime.Json.JsonNode ToJson(Microsoft.Azure.AzConfig.Runtime.Json.JsonObject container, Microsoft.Azure.AzConfig.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.AzConfig.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != Properties ? (Microsoft.Azure.AzConfig.Runtime.Json.JsonNode) Properties.ToJson(null) : null, "properties" ,container.Add );
            if (null != Tag)
            {
                var __u = new Microsoft.Azure.AzConfig.Runtime.Json.JsonObject();
                container.Add("tags", __u);
                foreach( var __x in Tag.Keys )
                {
                    var __v = Tag[__x];
                    AddIf( null != (((object)(__v as string))?.ToString()) ? (Microsoft.Azure.AzConfig.Runtime.Json.JsonNode) new Microsoft.Azure.AzConfig.Runtime.Json.JsonString((__v as string).ToString()) : null,(__w) => __u.Add(__x as string,__w ) );
                }
            }
            AfterToJson(ref container);
            return container;
        }
    }
}