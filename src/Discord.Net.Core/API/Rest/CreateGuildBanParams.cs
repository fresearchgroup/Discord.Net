﻿#pragma warning disable CS1591
using Newtonsoft.Json;

namespace Discord.API.Rest
{
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public class CreateGuildBanParams
    {
        public Optional<int> DeleteMessageDays { get; set; }
    }
}
