using System;
using NUnit.Framework;
using System.Collections.Generic;


namespace addressbook_test_white
{
    [TestFixture]
    public class GroupRemovalTests : TestBase
    {
        [Test]
        public void TestGroupRemoval()
        {
            int countGroup = app.Groups.GetGroupList().Count;
            if (countGroup <= 1)
            {
                app.Groups.Add(new GroupData() { Name = "for_remove" });
            }
            List<GroupData> oldGroups = app.Groups.GetGroupList();
          
            app.Groups.Remove(1);

            List<GroupData> newGroups = app.Groups.GetGroupList();

            oldGroups.RemoveAt(1);
            oldGroups.Sort();
            newGroups.Sort();
            Assert.AreEqual(oldGroups, newGroups);
        }
    }
}

