namespace Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Extensions;
    /// <summary>An API key used for authenticating with a configuration store endpoint.</summary>
    public partial class ApiKey : Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IApiKey
    {
        /// <summary>Backing field for <see cref="ConnectionString" /> property.</summary>
        private string _connectionString;

        /// <summary>A connection string that can be used by supporting clients for authentication.</summary>
        public string ConnectionString
        {
            get
            {
                return this._connectionString;
            }
            internal set
            {
                this._connectionString = value;
            }
        }
        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>The key ID.</summary>
        public string Id
        {
            get
            {
                return this._id;
            }
            internal set
            {
                this._id = value;
            }
        }
        /// <summary>Backing field for <see cref="LastModified" /> property.</summary>
        private System.DateTime? _lastModified;

        /// <summary>The last time any of the key's properties were modified.</summary>
        public System.DateTime? LastModified
        {
            get
            {
                return this._lastModified;
            }
            internal set
            {
                this._lastModified = value;
            }
        }
        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>A name for the key describing its usage.</summary>
        public string Name
        {
            get
            {
                return this._name;
            }
            internal set
            {
                this._name = value;
            }
        }
        /// <summary>Backing field for <see cref="ReadOnly" /> property.</summary>
        private bool? _readOnly;

        /// <summary>Whether this key can only be used for read operations.</summary>
        public bool? ReadOnly
        {
            get
            {
                return this._readOnly;
            }
            internal set
            {
                this._readOnly = value;
            }
        }
        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private string _value;

        /// <summary>The value of the key that is used for authentication purposes.</summary>
        public string Value
        {
            get
            {
                return this._value;
            }
            internal set
            {
                this._value = value;
            }
        }
        /// <summary>Creates an new <see cref="ApiKey" /> instance.</summary>
        public ApiKey()
        {
        }
    }
    /// An API key used for authenticating with a configuration store endpoint.
    public partial interface IApiKey : Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IJsonSerializable {
        string ConnectionString { get;  }
        string Id { get;  }
        System.DateTime? LastModified { get;  }
        string Name { get;  }
        bool? ReadOnly { get;  }
        string Value { get;  }
    }
}