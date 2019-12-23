using System;
using NUnit.Framework;

namespace GitUIPluginInterfaces.Tests
{
    [TestFixture]
    public class ManagedExtensibilityTests
    {
        [TestCase]
        public void ThrowWhenUserPluginsPathAlreadyInitialized()
        {
            ManagedExtensibility.SetUserPluginsPath("A");
            Assert.Throws<InvalidOperationException>(() => ManagedExtensibility.SetUserPluginsPath("B"));
        }
    }
}
