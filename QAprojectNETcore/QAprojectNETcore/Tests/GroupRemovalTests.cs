using NUnit.Framework;
using System.Runtime.InteropServices.ComTypes;

namespace WebAddressbookTests
{
    [TestFixture]
    class GroupRemovalTests : AuthTestBase
    {
        [Test,Order(4)]
        public void GroupRemovalTest()
        {
            app.Groups
                .Remove(1);
        }
    }
}
