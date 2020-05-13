﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace PinnacleWrapper.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum BetType
    {
        Spread,
        Moneyline,
        Total_Points,
        Team_Total_Points
    }
}