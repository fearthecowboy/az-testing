namespace Microsoft.Azure.AzConfig.Models
{
    using static Microsoft.Azure.AzConfig.Runtime.Extensions;
    /// <summary>The display information for a configuration store operation.</summary>
    public partial class OperationDefinitionDisplay : Microsoft.Azure.AzConfig.Models.IOperationDefinitionDisplay
    {
        /// <summary>Backing field for <see cref="Description" /> property.</summary>
        private string _description;

        /// <summary>The description for the operation.</summary>
        public string Description
        {
            get
            {
                return this._description;
            }
            set
            {
                this._description = value;
            }
        }
        /// <summary>Backing field for <see cref="Operation" /> property.</summary>
        private string _operation;

        /// <summary>The operation that users can perform.</summary>
        public string Operation
        {
            get
            {
                return this._operation;
            }
            set
            {
                this._operation = value;
            }
        }
        /// <summary>Backing field for <see cref="Provider" /> property.</summary>
        private string _provider;

        /// <summary>The resource provider name: Microsoft Azconfig."</summary>
        public string Provider
        {
            get
            {
                return this._provider;
            }
            internal set
            {
                this._provider = value;
            }
        }
        /// <summary>Backing field for <see cref="Resource" /> property.</summary>
        private string _resource;

        /// <summary>The resource on which the operation is performed.</summary>
        public string Resource
        {
            get
            {
                return this._resource;
            }
            set
            {
                this._resource = value;
            }
        }
        /// <summary>Creates an new <see cref="OperationDefinitionDisplay" /> instance.</summary>
        public OperationDefinitionDisplay()
        {
        }
    }
    /// The display information for a configuration store operation.
    public partial interface IOperationDefinitionDisplay : Microsoft.Azure.AzConfig.Runtime.IJsonSerializable {
        string Description { get; set; }
        string Operation { get; set; }
        string Provider { get;  }
        string Resource { get; set; }
    }
}