﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Platform.Modules.Jira.Remote
{
    /// <summary>
    /// Attribute that can be applied to properties to modify the name of the remotefield used when updating an issue
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    internal class RemoteFieldNameAttribute: Attribute
    {
        public string Name { get; set; }

        public RemoteFieldNameAttribute(string remoteFieldName)
        {
            this.Name = remoteFieldName;
        }
    }
}