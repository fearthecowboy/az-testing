namespace Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Extensions;
    /// <summary>The parameters for updating a configuration store.</summary>
    public partial class ConfigurationStoreUpdateParameters : Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IConfigurationStoreUpdateParameters, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref="Properties" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IConfigurationStorePropertiesUpdateParameters _properties;

        /// <summary>The properties for updating a configuration store.</summary>
        public Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IConfigurationStorePropertiesUpdateParameters Properties
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
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertObjectIsValid(nameof(Properties), Properties);
        }
    }
    /// The parameters for updating a configuration store.
    public partial interface IConfigurationStoreUpdateParameters : Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IJsonSerializable {
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IConfigurationStorePropertiesUpdateParameters Properties { get; set; }
        System.Collections.Hashtable Tag { get; set; }
    }
}