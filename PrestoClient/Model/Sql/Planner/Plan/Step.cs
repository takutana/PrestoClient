﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace BAMCIS.PrestoClient.Model.Sql.Planner.Plan
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Step
    {
        SINGLE,
        PARTIAL,
        FINAL
    }
}
