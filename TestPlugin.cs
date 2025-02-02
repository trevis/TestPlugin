using System.IO;
using System;
using Microsoft.Extensions.Logging;
using Chorizite.Core.Plugins;
using Chorizite.Core.Plugins.AssemblyLoader;
using Chorizite.Core;

namespace TestPlugin {
    /// <summary>
    /// CoreTestPlugin
    /// </summary>
    public class TestPluginCore : IPluginCore {
        internal static ILogger? Log;

        protected TestPluginCore(AssemblyPluginManifest manifest, ILogger log) : base(manifest) {
            Log = log;

            Log?.LogDebug($"TestPlugin Version: {Manifest.Version}");
        }

        protected override void Dispose() {
            
        }
    }
}
