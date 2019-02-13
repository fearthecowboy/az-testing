namespace Microsoft.Azure.AzConfig.Models
{
    using static Microsoft.Azure.AzConfig.Runtime.Extensions;
    /// <summary>The parameters for updating a configuration store.</summary>
    public partial class ConfigurationStoreUpdateParameters : Microsoft.Azure.AzConfig.Models.IConfigurationStoreUpdateParameters, Microsoft.Azure.AzConfig.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref="Properties" /> property.</summary>
        private Microsoft.Azure.AzConfig.Models.IConfigurationStorePropertiesUpdateParameters _properties;

        /// <summary>The properties for updating a configuration store.</summary>
        public Microsoft.Azure.AzConfig.Models.IConfigurationStorePropertiesUpdateParameters Properties
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
        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private System.Collections.Hashtable _tag;

        /// <summary>The ARM resource tags.</summary>
        public System.Collections.Hashtable Tag
        {
            get
            {
                return this._tag;
            }
            set
            {
                this._tag = value;
            }
        }
        /// <summary>Creates an new <see cref="ConfigurationStoreUpdateParameters" /> instance.</summary>
        public ConfigurationStoreUpdateParameters()
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
            await eventListener.AssertObjectIsValid(nameof(Properties), Properties);
        }
    }
    /// The parameters for updating a configuration store.
    public partial interface IConfigurationStoreUpdateParameters : Microsoft.Azure.AzConfig.Runtime.IJsonSerializable {
        Microsoft.Azure.AzConfig.Models.IConfigurationStorePropertiesUpdateParameters Properties { get; set; }
        System.Collections.Hashtable Tag { get; set; }
    }
}