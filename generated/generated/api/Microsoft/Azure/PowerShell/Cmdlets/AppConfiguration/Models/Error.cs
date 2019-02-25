namespace Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Extensions;
    /// <summary>AppConfiguration error object.</summary>
    public partial class Error : Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Models.IError
    {
        /// <summary>Backing field for <see cref="Code" /> property.</summary>
        private string _code;

        /// <summary>Error code.</summary>
        public string Code
        {
            get
            {
                return this._code;
            }
            set
            {
                this._code = value;
            }
        }
        /// <summary>Backing field for <see cref="Message" /> property.</summary>
        private string _message;

        /// <summary>Error message.</summary>
        public string Message
        {
            get
            {
                return this._message;
            }
            set
            {
                this._message = value;
            }
        }
        /// <summary>Creates an new <see cref="Error" /> instance.</summary>
        public Error()
        {
        }
    }
    /// AppConfiguration error object.
    public partial interface IError : Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.IJsonSerializable {
        string Code { get; set; }
        string Message { get; set; }
    }
}