namespace Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Extensions;
    /// <summary>The result of a request to list API keys.</summary>
    public partial class ApiKeyListResult : Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IApiKeyListResult, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IValidates
    {
        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The URI that can be used to request the next set of paged results.</summary>
        public string NextLink
        {
            get
            {
                return this._nextLink;
            }
            set
            {
                this._nextLink = value;
            }
        }
        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IApiKey[] _value;

        /// <summary>The collection value.</summary>
        public Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IApiKey[] Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
        /// <summary>Creates an new <see cref="ApiKeyListResult" /> instance.</summary>
        public ApiKeyListResult()
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
            if (Value != null ) {
                    for (int __i = 0; __i < Value.Length; __i++) {
                      await eventListener.AssertObjectIsValid($"Value[{__i}]", Value[__i]);
                    }
                  }
        }
    }
    /// The result of a request to list API keys.
    public partial interface IApiKeyListResult : Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IJsonSerializable {
        string NextLink { get; set; }
        Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IApiKey[] Value { get; set; }
    }
}