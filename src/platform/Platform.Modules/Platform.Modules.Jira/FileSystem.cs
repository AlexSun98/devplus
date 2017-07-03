﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Platform.Modules.Jira
{
    internal class FileSystem: IFileSystem
    {
        public byte[] FileReadAllBytes(string path)
        {
            return File.ReadAllBytes(path);
        }
    }
}
