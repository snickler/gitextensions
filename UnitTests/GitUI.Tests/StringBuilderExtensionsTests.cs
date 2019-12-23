using System.Text;
using GitCommands;
using NUnit.Framework;

namespace GitUI.Tests
{
    public sealed class StringBuilderExtensionsTests
    {
        [TestCase("foo", "foo")]
        [TestCase("\"foo bar\"", "foo bar")]
        [TestCase("\"foo\tbar\"", "foo\tbar")]
        [TestCase("\"foo bar\"", "\"foo bar\"")]
        [TestCase("\"\"", "")]
        [TestCase("\" \"", " ")]
        public void AppendQuoted(string expected, string source)
        {
            Assert.AreEqual(expected, new StringBuilder().AppendQuoted(source).ToString());
        }
    }
}