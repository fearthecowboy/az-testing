namespace Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Extensions;
    /// <summary>An Azure resource.</summary>
    public partial class Resource
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonObject json);
        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonObject container);
        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>
        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonObject json, ref bool returnNow);
        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>
        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonObject container, ref bool returnNow);
        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IResource.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IResource.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IResource FromJson(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonObject json ? new Resource(json) : null;
        }
        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonObject into a new instance of <see cref="Resource" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal Resource(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            _name = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonString>("name"), out var __jsonName) ? (string)__jsonName : (string)Name;
            _type = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonString>("type"), out var __jsonType) ? (string)__jsonType : (string)Type;
            _id = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonString>("id"), out var __jsonId) ? (string)__jsonId : (string)Id;
            _location = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonString>("location"), out var __jsonLocation) ? (string)__jsonLocation : (string)Location;
            _tag = /* 1 */ new System.Collections.Hashtable( System.Linq.Enumerable.ToDictionary<string,string, string>( json.Property("tags")?.Keys ?? System.Linq.Enumerable.Empty<string>(), each => each, each => json.Property("tags").PropertyT<Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonNode>(each) is Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonString __t ? (string)__t : null ));
            AfterFromJson(json);
        }
        /// <summary>
        /// Serializes this instance of <see cref="Resource" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="Resource" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)Name)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonString(Name.ToString()) : null, "name" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)Type)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonString(Type.ToString()) : null, "type" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.SerializationMode.IncludeReadOnly))
            {
                AddIf( null != (((object)Id)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonString(Id.ToString()) : null, "id" ,container.Add );
            }
            AddIf( null != (((object)Location)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonString(Location.ToString()) : null, "location" ,container.Add );
            if (null != Tag)
            {
                var __u = new Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonObject();
                container.Add("tags", __u);
                foreach( var __x in Tag.Keys )
                {
                    if ((null != Tag[__x] && Tag[__x] is string __v))
                    {
                        AddIf( null != (((object)__v)?.ToString()) ? (Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonNode) new Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json.JsonString(__v.ToString()) : null,(__w) => __u.Add(__x as string,__w ) );
                    }
                }
            }
            AfterToJson(ref container);
            return container;
        }
    }
}