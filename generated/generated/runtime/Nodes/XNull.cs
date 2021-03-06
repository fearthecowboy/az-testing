﻿namespace Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json
{
    internal sealed class XNull : JsonNode
    {
        internal static readonly XNull Instance = new XNull();

        private XNull() { }

        internal override JsonType Type => JsonType.Null;
    }
}