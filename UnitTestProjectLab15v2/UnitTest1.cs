using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Csharp_lab_15v2;
using Csharp_lab_15v2.Mock;
using System.Collections.Generic;

namespace UnitTestProjectLab15v2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<Group> groupDB = GroupDB.GetGroups();
            Group gr = new Group { department = "ИиПО", special = "ИВТ-2019", nmb = 2019 };
            var flag = AddTeacherDB.AddTeacher(gr, "Martin", "Lowrence", "34563875", "Mater");
            var teacher = SearchDB.GetTeacher("Alex");
            Assert.IsNotNull(groupDB);
            Assert.IsTrue(flag);
            Assert.IsNotNull(teacher);

        }
    }
}
