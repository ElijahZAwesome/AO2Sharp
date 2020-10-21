﻿namespace Alibi.Plugins.API
{
    public interface IPluginManager
    {
        public bool IsPluginLoaded(string id);
        public dynamic RequestPluginInstance(string id);
        public string GetConfigFolder(string id);
        public void Log(LogSeverity severity, string message, bool verbose);
    }
}