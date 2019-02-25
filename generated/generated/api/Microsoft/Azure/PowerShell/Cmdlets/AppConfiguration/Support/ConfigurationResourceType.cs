namespace Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Support
{

    public partial struct ConfigurationResourceType : System.IEquatable<ConfigurationResourceType>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Support.ConfigurationResourceType MicrosoftAppConfigurationConfigurationStores = @"Microsoft.AppConfiguration/configurationStores";
        /// <summary>the value for an instance of the <see cref="ConfigurationResourceType" /> Enum.</summary>
        private string _value {get;set;}
        /// <summary>Creates an instance of the <see cref="ConfigurationResourceType" Enum class./></summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private ConfigurationResourceType(string underlyingValue)
        {
            this._value = underlyingValue;
        }
        /// <summary>Compares values of enum type ConfigurationResourceType</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Support.ConfigurationResourceType e)
        {
            return _value.Equals(e._value);
        }
        /// <summary>Compares values of enum type ConfigurationResourceType (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is ConfigurationResourceType && Equals((ConfigurationResourceType)obj);
        }
        /// <summary>Returns hashCode for enum ConfigurationResourceType</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }
        /// <summary>Returns string representation for ConfigurationResourceType</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }
        /// <summary>Implicit operator to convert string to ConfigurationResourceType</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ConfigurationResourceType" />.</param>
        public static implicit operator ConfigurationResourceType(string value)
        {
            return new ConfigurationResourceType(value);
        }
        /// <summary>Implicit operator to convert ConfigurationResourceType to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="ConfigurationResourceType" />.</param>
        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Support.ConfigurationResourceType e)
        {
            return e._value;
        }
        /// <summary>Overriding != operator for enum ConfigurationResourceType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Support.ConfigurationResourceType e1, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Support.ConfigurationResourceType e2)
        {
            return !e2.Equals(e1);
        }
        /// <summary>Overriding == operator for enum ConfigurationResourceType</summary>
        /// <param name="e1">the value to compare against <see cref="e2" /></param>
        /// <param name="e2">the value to compare against <see cref="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Support.ConfigurationResourceType e1, Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Support.ConfigurationResourceType e2)
        {
            return e2.Equals(e1);
        }
    }
}