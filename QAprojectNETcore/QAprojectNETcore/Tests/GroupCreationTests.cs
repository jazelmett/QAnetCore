using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    class GroupCreationTests : AuthTestBase
    {
        [Test,Order(1)]
        public void GroupCreationTest()
        {
            GroupData group = new GroupData("newgroup")
            {
                Header = "gg",
                Footer = "ss"
            };

            app.Groups
                .Create(group);
        }

        [Test,Order(2)]
        public void EmptyGroupCreationTest()
        {
            GroupData group = new GroupData("")
            {
                Header = "",
                Footer = ""
            };

            app.Groups
                .Create(group);

        }

    }
}
