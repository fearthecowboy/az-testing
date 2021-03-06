
namespace Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime
{
    using System;

    public class UndeclaredResponseException : Exception
    {
        public UndeclaredResponseException(System.Net.HttpStatusCode code) : base($"A response with status code {code} was recieved, but this possibility was not declared in the specification.")
        {

        }
    }
}