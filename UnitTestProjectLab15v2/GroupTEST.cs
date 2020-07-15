using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Csharp_lab_15v2;
using Csharp_lab_15v2.Mock;
using System.Collections.Generic;

namespace UnitTestProjectLab15v2
{
    [TestClass]
    public class GroupTEST
    {
        [TestMethod]
        public void TestMethod1()
        {
            Group gr = new Group { department = "ИиПО", special = "ИВТ-2019", nmb = 2019 };
            Assert.IsNotNull(gr);
            Assert.IsInstanceOfType(gr, typeof(Group));
        }
    }
}
