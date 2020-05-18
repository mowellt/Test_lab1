using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testss.Test
{
    [TestFixture]
    class StringFormatterTest
    {
        [Test]
        public void NullThrows()
        {
            StringFormatter stringFormatter = new StringFormatter();
            Assert.Throws<NullReferenceException>(() => stringFormatter.WebString(null));
        }

        [Test]
        public void Empty()
        {
            StringFormatter stringFormatter = new StringFormatter();
            StringAssert.AreEqualIgnoringCase(stringFormatter.WebString(""), "");
        }

        [Test]
        [TestCase("some.git")]
        [TestCase("git://some.git")]
        public void AssertStartsWithGit(string uri)
        {
            StringFormatter stringFormatter = new StringFormatter();
            StringAssert.StartsWith("git://", stringFormatter.WebString(uri));
        }
        
        
        [Test]
        [TestCase("some.com")]
        [TestCase("some")]
        [TestCase("http://some.git")]
        public void StartsithHttp(string uri)
        {
            StringFormatter stringFormatter = new StringFormatter();
            StringAssert.StartsWith("http://", stringFormatter.WebString(uri));
        }
    }
}

