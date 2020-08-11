using NUnit.Framework;
using System.Runtime.InteropServices.ComTypes;

namespace WebAddressbookTests
{
    [TestFixture]
    class GroupRemovalTests : TestBase
    {
        [Test]
        public void GroupRemovalTest()
        {
            app.Groups.Remove(1);
        }
    }
}
