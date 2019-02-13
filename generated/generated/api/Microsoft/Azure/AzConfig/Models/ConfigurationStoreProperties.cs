namespace Microsoft.Azure.AzConfig.Models
{
    using static Microsoft.Azure.AzConfig.Runtime.Extensions;
    /// <summary>The properties of a configuration store.</summary>
    public partial class ConfigurationStoreProperties : Microsoft.Azure.AzConfig.Models.IConfigurationStoreProperties, Microsoft.Azure.AzConfig.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref="CreationDate" /> property.</summary>
        private System.DateTime? _creationDate;

        /// <summary>The creation date of configuration store.</summary>
        public System.DateTime? CreationDate
        {
            get
            {
                return this._creationDate;
            }
            internal set
            {
                this._creationDate = value;
            }
        }
        /// <summary>Backing field for <see cref="Endpoint" /> property.</summary>
        private string _endpoint;

        /// <summary>The DNS endpoint where the configuration store API will be available.</summary>
        public string Endpoint
        {
            get
            {
                return this._endpoint;
            }
            internal set
            {
                this._endpoint = value;
            }
        }
        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private Microsoft.Azure.AzConfig.Support.ProvisioningState _provisioningState;

        /// <summary>The provisioning state of the configuration store.</summary>
        public Microsoft.Azure.AzConfig.Support.ProvisioningState ProvisioningState
        {
            get
            {
                return this._provisioningState;
            }
            internal set
            {
                this._provisioningState = value;
            }
        }
        /// <summary>Creates an new <see cref="ConfigurationStoreProperties" /> instance.</summary>
        public ConfigurationStoreProperties()
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
            await eventListener.AssertEnum(nameof(ProvisioningState),ProvisioningState,@"Creating", @"Updating", @"Deleting", @"Succeeded", @"Failed", @"Canceled");
        }
    }
    /// The properties of a configuration store.
    public partial interface IConfigurationStoreProperties : Microsoft.Azure.AzConfig.Runtime.IJsonSerializable {
        System.DateTime? CreationDate { get;  }
        string Endpoint { get;  }
        Microsoft.Azure.AzConfig.Support.ProvisioningState ProvisioningState { get;  }
    }
}