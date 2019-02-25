namespace Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Extensions;
    /// <summary>The definition of a configuration store operation.</summary>
    public partial class OperationDefinition : Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IOperationDefinition, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref="Display" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IOperationDefinitionDisplay _display;

        /// <summary>The display information for the configuration store operation.</summary>
        public Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IOperationDefinitionDisplay Display
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
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref="System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertObjectIsValid(nameof(Display), Display);
        }
    }
    /// The definition of a configuration store operation.
    public partial interface IOperationDefinition : Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IJsonSerializable {
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IOperationDefinitionDisplay Display { get; set; }
        string Name { get; set; }
    }
}