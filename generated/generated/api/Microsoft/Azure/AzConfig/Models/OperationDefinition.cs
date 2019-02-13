namespace Microsoft.Azure.AzConfig.Models
{
    using static Microsoft.Azure.AzConfig.Runtime.Extensions;
    /// <summary>The definition of a configuration store operation.</summary>
    public partial class OperationDefinition : Microsoft.Azure.AzConfig.Models.IOperationDefinition, Microsoft.Azure.AzConfig.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref="Display" /> property.</summary>
        private Microsoft.Azure.AzConfig.Models.IOperationDefinitionDisplay _display;

        /// <summary>The display information for the configuration store operation.</summary>
        public Microsoft.Azure.AzConfig.Models.IOperationDefinitionDisplay Display
        {
            get
            {
                return this._display;
            }
            set
            {
                this._display = value;
            }
        }
        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Operation name: {provider}/{resource}/{operation}.</summary>
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
        /// <summary>Creates an new <see cref="OperationDefinition" /> instance.</summary>
        public OperationDefinition()
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
            await eventListener.AssertObjectIsValid(nameof(Display), Display);
        }
    }
    /// The definition of a configuration store operation.
    public partial interface IOperationDefinition : Microsoft.Azure.AzConfig.Runtime.IJsonSerializable {
        Microsoft.Azure.AzConfig.Models.IOperationDefinitionDisplay Display { get; set; }
        string Name { get; set; }
    }
}