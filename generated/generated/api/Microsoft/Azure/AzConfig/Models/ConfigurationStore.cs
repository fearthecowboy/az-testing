namespace Microsoft.Azure.AzConfig.Models
{
    using static Microsoft.Azure.AzConfig.Runtime.Extensions;
    /// <summary>
    /// The configuration store along with all resource properties. The Configuration Store will have all information to begin
    /// utlizing it.
    /// </summary>
    public partial class ConfigurationStore : Microsoft.Azure.AzConfig.Models.IConfigurationStore, Microsoft.Azure.AzConfig.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref="ConfigurationStore" /></summary>
        private Microsoft.Azure.AzConfig.Models.IResource _resource = new Microsoft.Azure.AzConfig.Models.Resource();
        /// <summary>Inherited model <see cref="IResource" /> - An Azure resource.</summary>
        public string Id
        {
            get
            {
                return _resource.Id;
            }
        }
        /// <summary>Inherited model <see cref="IResource" /> - An Azure resource.</summary>
        public string Location
        {
            get
            {
                return _resource.Location;
            }
            set
            {
                _resource.Location = value;
            }
        }
        /// <summary>Inherited model <see cref="IResource" /> - An Azure resource.</summary>
        public string Name
        {
            get
            {
                return _resource.Name;
            }
        }
        /// <summary>Backing field for <see cref="Properties" /> property.</summary>
        private Microsoft.Azure.AzConfig.Models.IConfigurationStoreProperties _properties;

        /// <summary>The properties of a configuration store.</summary>
        public Microsoft.Azure.AzConfig.Models.IConfigurationStoreProperties Properties
        {
            get
            {
                return this._properties;
            }
            set
            {
                this._properties = value;
            }
        }
        /// <summary>Inherited model <see cref="IResource" /> - An Azure resource.</summary>
        public System.Collections.Hashtable Tag
        {
            get
            {
                return _resource.Tag;
            }
            set
            {
                _resource.Tag = value;
            }
        }
        /// <summary>Inherited model <see cref="IResource" /> - An Azure resource.</summary>
        public string Type
        {
            get
            {
                return _resource.Type;
            }
        }
        /// <summary>Creates an new <see cref="ConfigurationStore" /> instance.</summary>
        public ConfigurationStore()
        {
        }
        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.AzConfig.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async System.Threading.Tasks.Task Validate(Microsoft.Azure.AzConfig.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(_resource), _resource);
            await eventListener.AssertObjectIsValid(nameof(_resource), _resource);
            await eventListener.AssertObjectIsValid(nameof(Properties), Properties);
        }
    }
    /// The configuration store along with all resource properties. The Configuration Store will have all information to begin
    /// utlizing it.
    public partial interface IConfigurationStore : Microsoft.Azure.AzConfig.Runtime.IJsonSerializable, Microsoft.Azure.AzConfig.Models.IResource {
        Microsoft.Azure.AzConfig.Models.IConfigurationStoreProperties Properties { get; set; }
    }
}