namespace Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Extensions;
    /// <summary>The result of a request to check the availability of a resource name.</summary>
    public partial class NameAvailabilityStatus : Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.INameAvailabilityStatus
    {
        /// <summary>Backing field for <see cref="Message" /> property.</summary>
        private string _message;

        /// <summary>
        /// If any, the error message that provides more detail for the reason that the name is not available.
        /// </summary>
        public string Message
        {
            get
            {
                return this._message;
            }
            internal set
            {
                this._message = value;
            }
        }
        /// <summary>Backing field for <see cref="NameAvailable" /> property.</summary>
        private bool? _nameAvailable;

        /// <summary>The value indicating whether the resource name is available.</summary>
        public bool? NameAvailable
        {
            get
            {
                return this._nameAvailable;
            }
            internal set
            {
                this._nameAvailable = value;
            }
        }
        /// <summary>Backing field for <see cref="Reason" /> property.</summary>
        private string _reason;

        /// <summary>If any, the reason that the name is not available.</summary>
        public string Reason
        {
            get
            {
                return this._reason;
            }
            internal set
            {
                this._reason = value;
            }
        }
        /// <summary>Creates an new <see cref="NameAvailabilityStatus" /> instance.</summary>
        public NameAvailabilityStatus()
        {
        }
    }
    /// The result of a request to check the availability of a resource name.
    public partial interface INameAvailabilityStatus : Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IJsonSerializable {
        string Message { get;  }
        bool? NameAvailable { get;  }
        string Reason { get;  }
    }
}