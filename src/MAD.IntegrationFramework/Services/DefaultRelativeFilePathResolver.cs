﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace MAD.IntegrationFramework.Services
{
    internal class DefaultRelativeFilePathResolver : IRelativeFilePathResolver
    {
        private string SettingsDirectory => Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);

        public string GetRelativeFilePath (string filePath)
        {
            return Path.Combine(this.SettingsDirectory, filePath);
        }
    }
}