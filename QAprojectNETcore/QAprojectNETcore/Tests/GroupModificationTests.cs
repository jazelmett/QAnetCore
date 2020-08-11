using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebAddressbookTests
{
    [TestFixture]
    class GroupModificationTests : TestBase
    {
        [Test]
        public void GroupModificationTest()
        {
            GroupData newData = new GroupData("zzz")
            {
                Header = null,
                Footer = null
            };

            app.Groups.Modify(1, newData);
        }
    }
}
