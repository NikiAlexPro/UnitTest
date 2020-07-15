using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Csharp_lab_15v2;
using Csharp_lab_15v2.Mock;
using System.Collections.Generic;

namespace UnitTestProjectLab15v2
{
    [TestClass]
    public class SearchDBTEST
    {
        [TestMethod]
        public void TestMethod1()
        {
            var teacher = SearchDB.GetTeacher("Alex");
            Assert.IsNotNull(teacher);
        }
    }
}
