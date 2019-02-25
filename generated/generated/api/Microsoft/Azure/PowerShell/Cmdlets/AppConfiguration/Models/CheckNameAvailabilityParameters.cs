namespace Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Extensions;
    /// <summary>Parameters used for checking whether a resource name is available.</summary>
    public partial class CheckNameAvailabilityParameters : Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.ICheckNameAvailabilityParameters, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>The name to check for availability.</summary>
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Support.ConfigurationResourceType _type;

        /// <summary>The resource type to check for name availability.</summary>
        public Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Support.ConfigurationResourceType Type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
            }
        }
        /// <summary>Creates an new <see cref="CheckNameAvailabilityParameters" /> instance.</summary>
        public CheckNameAvailabilityParameters()
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
            await eventListener.AssertNotNull(nameof(Name),Name);
            await eventListener.AssertNotNull(nameof(Type),Type);
            await eventListener.AssertEnum(nameof(Type),Type,@"Microsoft.AppConfiguration/configurationStores");
        }
    }
    /// Parameters used for checking whether a resource name is available.
    public partial interface ICheckNameAvailabilityParameters : Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IJsonSerializable {
        string Name { get; set; }
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Support.ConfigurationResourceType Type { get; set; }
    }
}