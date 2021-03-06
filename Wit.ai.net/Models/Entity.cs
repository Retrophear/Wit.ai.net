﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wit.Ai.Net.Models
{
    public class Entity
    {
        public string metadata { get; set; }

        public JToken value { get; set; }

        public double confidence { get; set; }
    }
}
