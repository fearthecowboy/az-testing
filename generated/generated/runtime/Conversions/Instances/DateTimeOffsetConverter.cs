﻿using System;

namespace Microsoft.Azure.PowerShell.Cmdlets.AppConfiguration.Runtime.Json
{
    public sealed class DateTimeOffsetConverter : JsonConverter<DateTimeOffset>
    {
        internal override JsonNode ToJson(DateTimeOffset value) => new JsonDate(value);

        internal override DateTimeOffset FromJson(JsonNode node) => (DateTimeOffset)node;
    }
}