namespace Microsoft.Azure.AzConfig.Models
{
    using static Microsoft.Azure.AzConfig.Runtime.Extensions;
    /// <summary>
    /// Error response indicates Logic service is not able to process the incoming request. The error property contains the error
    /// details.
    /// </summary>
    public partial class Error : Microsoft.Azure.AzConfig.Models.IError, Microsoft.Azure.AzConfig.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref="ErrorProperty" /> property.</summary>
        private Microsoft.Azure.AzConfig.Models.IErrorProperties _errorProperty;

        /// <summary>The error properties.</summary>
        public Microsoft.Azure.AzConfig.Models.IErrorProperties ErrorProperty
        {
            get
            {
                return this._errorProperty;
            }
            set
            {
                this._errorProperty = value;
            }
        }
        /// <summary>Creates an new <see cref="Error" /> instance.</summary>
        public Error()
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
            await eventListener.AssertObjectIsValid(nameof(ErrorProperty), ErrorProperty);
        }
    }
    /// Error response indicates Logic service is not able to process the incoming request. The error property contains the error
    /// details.
    public partial interface IError : Microsoft.Azure.AzConfig.Runtime.IJsonSerializable {
        Microsoft.Azure.AzConfig.Models.IErrorProperties ErrorProperty { get; set; }
    }
}