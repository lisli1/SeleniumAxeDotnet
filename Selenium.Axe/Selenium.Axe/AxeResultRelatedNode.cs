﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace Selenium.Axe
{
    public class AxeResultRelatedNode
    {
        public string Html { get; set; }
        
        [JsonProperty("target", ItemConverterType = typeof(AxeResultTargetConverter), NullValueHandling = NullValueHandling.Ignore)]
        public List<AxeResultTarget> Target { get; set; }
    }
}
