﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slickflow.Engine.Parser
{
    /// <summary>
    /// Package 类
    /// </summary>
    public class package
    {
        public List<participant> participants { get; set; }
        public process process { get; set; }
    }
}
