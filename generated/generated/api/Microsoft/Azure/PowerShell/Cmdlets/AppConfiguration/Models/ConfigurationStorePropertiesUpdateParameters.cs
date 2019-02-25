namespace Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Extensions;
    /// <summary>The properties for updating a configuration store.</summary>
    public partial class ConfigurationStorePropertiesUpdateParameters : Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IConfigurationStorePropertiesUpdateParameters
    {
        /// <summary>Backing field for <see cref="Enabled" /> property.</summary>
        private bool? _enabled;

        /// <summary>
        /// The value of this property indicates whether the configuration store endpoint should be enabled to serve requests.
        /// </summary>
        public bool? Enabled
        {
            get
            {
                return this._enabled;
            }
            set
            {
                this._enabled = value;
            }
        }
        /// <summary>
        /// Creates an new <see cref="ConfigurationStorePropertiesUpdateParameters" /> instance.
        /// </summary>
        public ConfigurationStorePropertiesUpdateParameters()
        {
        }
    }
    /// The properties for updating a configuration store.
    public partial interface IConfigurationStorePropertiesUpdateParameters : Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IJsonSerializable {
        bool? Enabled { get; set; }
    }
}