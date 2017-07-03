﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Platform.Modules.Jira
{
    /// <summary>
    /// Additional data to update when executing a workflow transition.
    /// </summary>
    public class WorkflowTransitionUpdates
    {
        /// <summary>
        /// Comment to add to issue when executing a workflow transition.
        /// </summary>
        public string Comment { get; set; }
    }
}
