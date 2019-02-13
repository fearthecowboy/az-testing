namespace Microsoft.Azure.AzConfig.Models
{
    using static Microsoft.Azure.AzConfig.Runtime.Extensions;
    /// <summary>Azconfig error properties.</summary>
    public partial class ErrorProperties : Microsoft.Azure.AzConfig.Models.IErrorProperties
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
        /// <summary>Creates an new <see cref="ErrorProperties" /> instance.</summary>
        public ErrorProperties()
        {
        }
    }
    /// Azconfig error properties.
    public partial interface IErrorProperties : Microsoft.Azure.AzConfig.Runtime.IJsonSerializable {
        string Code { get; set; }
        string Message { get; set; }
    }
}