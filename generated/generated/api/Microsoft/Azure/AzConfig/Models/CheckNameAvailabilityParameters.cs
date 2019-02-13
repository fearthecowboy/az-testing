namespace Microsoft.Azure.AzConfig.Models
{
    using static Microsoft.Azure.AzConfig.Runtime.Extensions;
    /// <summary>Parameters used for checking whether a resource name is available.</summary>
    public partial class CheckNameAvailabilityParameters : Microsoft.Azure.AzConfig.Models.ICheckNameAvailabilityParameters, Microsoft.Azure.AzConfig.Runtime.IValidates
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
        private Microsoft.Azure.AzConfig.Support.ConfigurationResourceType _type;

        /// <summary>The resource type to check for name availability.</summary>
        public Microsoft.Azure.AzConfig.Support.ConfigurationResourceType Type
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
        /// <param name="eventListener">an <see cref="Microsoft.Azure.AzConfig.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async System.Threading.Tasks.Task Validate(Microsoft.Azure.AzConfig.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(Name),Name);
            await eventListener.AssertNotNull(nameof(Type),Type);
            await eventListener.AssertEnum(nameof(Type),Type,@"Microsoft.Azconfig/configurationStores");
        }
    }
    /// Parameters used for checking whether a resource name is available.
    public partial interface ICheckNameAvailabilityParameters : Microsoft.Azure.AzConfig.Runtime.IJsonSerializable {
        string Name { get; set; }
        Microsoft.Azure.AzConfig.Support.ConfigurationResourceType Type { get; set; }
    }
}