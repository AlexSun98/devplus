﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Platform.Modules.Jira.Linq
{
    public class JqlData
    {
        public string Expression { get; set; }
        public int? NumberOfResults { get; set; }
        public int? SkipResults { get; set; }
    }
}
